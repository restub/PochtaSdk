using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Category and object types.
    /// Категория с объектами расчета.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.6)
    /// </summary>
    [DataContract]
    public class CategoryObjectTypes
    {
        /// <summary>
        /// Category identity.
        /// Код категории.
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Actual date.
        /// Дата получения справочной информации.
        /// </summary>
        [DataMember(Name = "date"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Category name.
        /// Наименование категории объекта расчета.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Category description.
        /// Описание категории объекта расчета.
        /// </summary>
        [DataMember(Name = "desc")]
        public string Description { get; set; }

        /// <summary>
        /// Object names in the category.
        /// Наименование вариантов объектов в категории.
        /// </summary>
        [DataMember(Name = "productname")]
        public string ProductName { get; set; }

        /// <summary>
        /// Object types.
        /// Список объектов расчета.
        /// </summary>
        [DataMember(Name = "object")]
        public ObjectTypeInfo[] ObjectTypes { get; set; }
    }
}
