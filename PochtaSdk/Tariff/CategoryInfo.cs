using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Category information.
    /// Информация о категории.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.2)
    /// </summary>
    [DataContract]
    public class CategoryInfo
    {
        /// <summary>
        /// Category identity.
        /// Код категории.
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Category name.
        /// Наименование категории (внутренние отправления, международные отправления).
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Child categories.
        /// Массив подчиненных категорий.
        /// </summary>
        [DataMember(Name = "child")]
        public CategoryInfo[] Children { get; set; }
    }
}
