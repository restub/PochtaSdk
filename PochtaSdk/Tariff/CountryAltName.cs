using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Country alternative name information.
    /// Информация об альтернативном названии страны.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.6)
    /// </summary>
    [DataContract]
    public class CountryAltName
    {
        [DataMember(Name = "type")]
        public CountryAltNameType Type { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
