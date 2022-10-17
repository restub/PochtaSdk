using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Entry types for customs declarations.
    /// Типы вложений для таможенной декларации.
    /// https://otpravka.pochta.ru/specification#/enums-base-entries-type
    /// </summary>
    [DataContract]
    public enum CustomsEntryType
    {
        /// <summary>
        /// Gift
        /// Подарок
        /// </summary>
        [EnumMember(Value = "GIFT")]
        Gift,

        /// <summary>
        /// Documents
        /// Документы
        /// </summary>
        [EnumMember(Value = "DOCUMENT")]
        Documents,

        /// <summary>
        /// Sold goods
        /// Продажа товара
        /// </summary>
        [EnumMember(Value = "SALE_OF_GOODS")]
        SaleOfGoods,

        /// <summary>
        /// Commercial sample
        /// Коммерческий образец
        /// </summary>
        [EnumMember(Value = "COMMERCIAL_SAMPLE")]
        CommercialSample,

        /// <summary>
        /// Other
        /// Прочее
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,
    }
}
