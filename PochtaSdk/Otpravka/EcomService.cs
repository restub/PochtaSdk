using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// ECOM services.
    /// Коды видов сервисов ЕКОМ.
    /// https://otpravka.pochta.ru/specification#/enums-ecom-services
    /// </summary>
    [DataContract]
    public enum EcomService
    {
        /// <summary>
        /// Без сервиса
        /// </summary>
        [EnumMember(Value = "WITHOUT_SERVICE")]
        WithoutService,

        /// <summary>
        /// Без вскрытия
        /// </summary>
        [EnumMember(Value = "WITHOUT_OPENING")]
        WithoutOpening,

        /// <summary>
        /// С проверкой вложения
        /// </summary>
        [EnumMember(Value = "CONTENTS_CHECKING")]
        ContentChecking,

        /// <summary>
        /// С примеркой
        /// </summary>
        [EnumMember(Value = "WITH_FITTING")]
        WithFitting,

        /// <summary>
        /// Доставка курьером
        /// </summary>
        [EnumMember(Value = "COURIER_DELIVERY")]
        CourierDelivery,

        /// <summary>
        /// С частичным выкупом
        /// </summary>
        [EnumMember(Value = "PARTIAL_REDEMPTION")]
        PartialRedemption,

        /// <summary>
        /// С проверкой работоспособности
        /// </summary>
        [EnumMember(Value = "FUNCTIONALITY_CHECKING")]
        FunctionalityChecking,
    }
}
