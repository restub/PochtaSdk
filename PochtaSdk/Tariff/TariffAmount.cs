using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariff amount.
    /// Значение тарифа.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.7)
    /// </summary>
    [DataContract]
    public class TariffAmount
    {
        /// <summary>
        /// Tariff amount, no VAT, cents.
        /// Значение тарифа, без НДС, в копейках.
        /// </summary>
        [DataMember(Name = "val")]
        public int Value { get; set; }

        /// <summary>
        /// Tariff amount, including VAT, cents.
        /// Значение тарифа, включая НДС, в копейках.
        /// </summary>
        [DataMember(Name = "valnds")]
        public int ValueNds { get; set; }

        /// <summary>
        /// Tariff amount if paid with postal stamps, cents.
        /// Значение тарифа при оплате почтовыми марками, в копейках.
        /// </summary>
        [DataMember(Name = "valmark")]
        public int? ValueMark { get; set; }

        /// <summary>
        /// Tariff amount if paid with SDR, cents.
        /// Значение тарифа при оплате СПЗ, в копейках.
        /// </summary>
        [DataMember(Name = "valsdr")]
        public int? ValueSdr { get; set; }
    }
}
