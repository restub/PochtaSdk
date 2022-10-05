using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Service info.
    /// Описание услуги.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.8)
    /// </summary>
    [DataContract]
    public class ServiceInfo
    {
        /// <summary>
        /// Service type identity.
        /// Код типа услуги.
        /// </summary>
        [DataMember(Name = "id")]
        public ServiceType ServiceType { get; set; }

        [IgnoreDataMember]
        public int ID => (int)ServiceType;

        /// <summary>
        /// Service name.
        /// Название услуги.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Service code.
        /// Код отметки по РТМ-2 в виде степени двойки.
        /// </summary>
        [DataMember(Name = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Service rank.
        /// Код разряда отправления по РТМ-2.
        /// </summary>
        [DataMember(Name = "rank")]
        public int? Rank { get; set; }
    }
}
