using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order short information.
    /// Заказ, краткая информация.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class OrderShortInfo
    {
        [DataMember(Name = "barcode")]
        public string Barcode { get; set; }

        [DataMember(Name = "order-num")]
        public string OrderNum { get; set; }

        [DataMember(Name = "result-id")]
        public int ResultID { get; set; }

        [DataMember(Name = "group-name")]
        public string GroupName { get; set; }
    }
}
