using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Countries response type.
    /// Список стран.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.7)
    /// </summary>
    [DataContract]
    public class CountriesResponse : BaseResponse
    {
        /// <summary>
        /// Country identity list.
        /// Список кодов запрошенных стран.
        /// </summary>
        [DataMember(Name = "id")]
        public int[] CountryIDs { get; set; }

        // <summary>
        /// Countries.
        /// Страны.
        /// </summary>
        [DataMember(Name = "country")]
        public CountryInfo[] Countries{ get; set; }
    }
}
