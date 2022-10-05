using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariffication object type service info.
    /// Услуга объекта тарификации.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.6)
    /// </summary>
    [DataContract]
    public class ObjectTypeServiceInfo
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
        /// Tariff calculation object service name.
        /// Название услуги объекта расчета.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Sequential number.
        /// Порядковый номер в пользовательском интерфейсе.
        /// </summary>
        [DataMember(Name = "seq")]
        public int Seq { get; set; }

        /// <summary>
        /// ServiceOff.
        /// </summary>
        [DataMember(Name = "serviceoff")]
        public int[] ServiceOff { get; set; }
    }
}
