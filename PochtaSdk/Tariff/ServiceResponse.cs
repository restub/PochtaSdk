using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Service response type.
    /// Список услуг.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Chapter 2.6)
    /// </summary>
    [DataContract]
    public class ServiceResponse : BaseResponse
    {
        /// <summary>
        /// Service identities.
        /// Список запрашиваемых кодов услуг.
        /// </summary>
        [DataMember(Name = "id")]
        public int[] ServiceIds { get; set; }

        /// <summary>
        /// Services.
        /// Услуги.
        /// </summary>
        [DataMember(Name = "service")]
        public ServiceInfo[] Services { get; set; }

        [DataMember(Name = "date"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Response name.
        /// Название ответа.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
