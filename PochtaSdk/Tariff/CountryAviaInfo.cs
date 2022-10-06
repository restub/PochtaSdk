using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Country avia information.
    /// Информация об авиапочте в стране.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.6)
    /// </summary>
    [DataContract]
    public class CountryAviaInfo
    {
        [DataMember(Name = "block")]
        public int Block { get; set; }

        [DataMember(Name = "sizemax")]
        public SizeMax SizeMax { get; set; }
    }
}
