using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Calculated delivery terms.
    /// Значение контрольного срока доставки.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.8)
    /// </summary>
    [DataContract]
    public class DeliveryTerms
    {
        [DataMember(Name = "min")]
        public int Min { get; set; }

        [DataMember(Name = "max")]
        public int Max { get; set; }

        [DataMember(Name = "deadline"), JsonConverter(typeof(TariffDateTimeConverter))]
        public DateTime Deadline { get; set; }
    }
}
