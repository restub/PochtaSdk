using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Post office response type.
    /// Список почтовых отделений.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.8)
    /// </summary>
    [DataContract]
    public class PostOfficesResponse : BaseResponse
    {
        /// <summary>
        /// Post code list.
        /// Список индексов запрошенных отделений.
        /// </summary>
        [DataMember(Name = "id")]
        public int[] PostCodes { get; set; }

        /// <summary>
        /// Post offices.
        /// Почтовые отделения.
        /// </summary>
        [DataMember(Name = "postoffice")]
        public PostOffice[] PostOffices { get; set; }
    }
}
