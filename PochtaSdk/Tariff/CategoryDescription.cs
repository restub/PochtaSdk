using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Category description.
    /// Описание категории объектов расчета.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.3)
    /// </summary>
    [DataContract]
    public class CategoryDescription
    {
        /// <summary>
        /// Category identity.
        /// Код категории.
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Category name.
        /// Наименование категории.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Category description.
        /// Описание категорий почтовых отправлений.
        /// </summary>
        [DataMember(Name = "desc")]
        public string Description { get; set; }

        /// <summary>
        /// Child categories.
        /// Массив подчиненных категорий.
        /// </summary>
        [DataMember(Name = "category")]
        public CategoryDescription[] Children { get; set; }
    }
}
