using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping rate, delivery times.
    /// Расчет стоимости пересылки, время доставки.
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public class ShippingDeliveryTime
    {
        /// <summary>
        /// Максимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "max-days")]
        public int MaxDays { get; set; }

        /// <summary>
        /// Минимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "min-days")]
        public int MinDays { get; set; }
    }
}
