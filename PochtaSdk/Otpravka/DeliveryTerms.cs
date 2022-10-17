using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Delivery terms.
    /// Сроки доставки.
    /// https://otpravka.pochta.ru/specification#/orders-search_order_byid
    /// </summary>
    [DataContract]
    public class DeliveryTerms
    {
        /// <summary>
        /// Максимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "max-days")]
        public int? MaxDays { get; set; }

        /// <summary>
        /// Минимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "min-days")]
        public int? MinDays { get; set; }
    }
}