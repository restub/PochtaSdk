using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order response.
    /// Заказ, ответ.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class OrderResponse : IHasErrors
    {
        [DataMember(Name = "errors")]
        public ErrorWithCode[] Errors { get; set; }

        [DataMember(Name = "result-ids")] // v1
        public int[] ResultIDs { get; set; }

        [DataMember(Name = "orders")] // v2
        public OrderShortInfo[] Orders { get; set; }

        public bool HasErrors() => Errors != null && Errors.Any();

        public string GetErrorMessage() =>
            string.Join(". ", (Errors ?? Enumerable.Empty<ErrorWithCode>()).Select(e => e.Description));
    }
}
