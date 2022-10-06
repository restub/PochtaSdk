using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Category info response type.
    /// Список категорий.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.2)
    /// </summary>
    [DataContract]
    public class CategoryInfoResponse : BaseResponse
    {
        /// <summary>
        /// Root category identity.
        /// Код корневой категории.
        /// </summary>
        [DataMember(Name = "id")]
        public int RootID { get; set; }

        // <summary>
        /// Categories.
        /// Категории.
        /// </summary>
        [DataMember(Name = "category")]
        public CategoryInfo[] Categories{ get; set; }
    }
}
