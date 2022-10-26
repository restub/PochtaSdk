using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping rate, money and taxes.
    /// Расчет стоимости пересылки, суммы с налогами.
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public class ShippingRateAmounts
    {
        /// <summary>
        /// Тариф без НДС (коп)
        /// </summary>
        [DataMember(Name = "rate")]
        public int Rate { get; set; }

        /// <summary>
        /// НДС (коп)
        /// </summary>
        [DataMember(Name = "vat")]
        public int Vat { get; set; }
    }
}
