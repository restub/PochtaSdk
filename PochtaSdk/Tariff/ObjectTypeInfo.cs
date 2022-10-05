using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariffication object type and its description.
    /// Тип объекта тарификации и его описание.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.6)
    /// </summary>
    [DataContract]
    public class ObjectTypeInfo
    {
        /// <summary>
        /// Object type identity.
        /// Код типа объекта.
        /// </summary>
        [DataMember(Name = "id")]
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// Object type identity as a number.
        /// Код типа объекта в виде целого числа.
        /// </summary>
        [IgnoreDataMember]
        public int ID => (int)ObjectType;

        /// <summary>
        /// Shippings only: mail type.
        /// Только для отправлений: вид отправления, согласно РТМ-2
        /// </summary>
        [DataMember(Name = "mailtype")]
        public int MailType { get; set; }

        /// <summary>
        /// Shippings only: mail category.
        /// Только для отправлений: категория отправления, согласно РТМ-2
        /// </summary>
        [DataMember(Name = "mailctg")]
        public int MailCategory { get; set; }

        /// <summary>
        /// Shippings only: direction category.
        /// Только для отправлений: направление доставки.
        /// </summary>
        [DataMember(Name = "directctg")]
        public int DirectCategory { get; set; }

        /// <summary>
        /// Tariff calculation object type name.
        /// Название типа объекта расчета.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "date"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime Date { get; set; }

        [DataMember(Name = "country-group")]
        public string CountryGroup { get; set; }

        [DataMember(Name = "params")]
        public ObjectTypeParameterInfo[] Parameters { get; set; }

        [DataMember(Name = "service")]
        public ObjectTypeServiceInfo[] Services { get; set; }
    }
}
