using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order creation/deletion response.
    /// Ответ метода создания или удаления заказов.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/orders-delete_new_order
    /// </summary>
    [DataContract]
    public class OrderResponse : IHasErrors
    {
        [DataMember(Name = "errors")]
        public Error[] Errors { get; set; }

        [DataMember(Name = "result-ids")] // v1.0
        public long[] ResultIDs { get; set; }

        [DataMember(Name = "orders")] // v2.0
        public OrderShortInfo[] Orders { get; set; }

        private IEnumerable<ErrorWithCode> ErrorsWithCodes =>
            from err in Errors ?? Enumerable.Empty<Error>()
            orderby err.Position
            from ewc in err.ErrorCodes ?? Enumerable.Empty<ErrorWithCode>()
            orderby ewc.Position
            select ewc;

        private bool HasOrders => Orders != null && Orders.Any();

        public bool HasErrors() => !HasOrders && ErrorsWithCodes.Any();

        public string GetErrorMessage() =>
            string.Join(". ", ErrorsWithCodes.Select(e => e.Description));
    }
}
