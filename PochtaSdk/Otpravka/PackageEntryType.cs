using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Package entry types for rate calculation and for customs declarations.
    /// Типы вложений посылок для расчета тарифов и для таможенной декларации.
    /// https://otpravka.pochta.ru/specification#/enums-base-entries-type
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public enum PackageEntryType
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
