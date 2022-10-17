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
        public ErrorWithCode[] Errors { get; set; }

        [DataMember(Name = "result-ids")] // v1.0
        public int[] ResultIDs { get; set; }

        [DataMember(Name = "orders")] // v2.0
        public OrderShortInfo[] Orders { get; set; }

        public bool HasErrors() => Errors != null && Errors.Any();

        public string GetErrorMessage() =>
            string.Join(". ", (Errors ?? Enumerable.Empty<ErrorWithCode>()).Select(e => e.Description));
    }
}
