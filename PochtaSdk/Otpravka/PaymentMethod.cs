using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Payment method.
    /// Способ оплаты.
    /// https://otpravka.pochta.ru/specification#/enums-payment-methods
    /// </summary>
    [DataContract]
    public enum PaymentMethod
    {
        /// <summary>
        /// Безналичный расчет
        /// </summary>
        [EnumMember(Value = "CASHLESS")]
        Cashless,

        /// <summary>
        /// Оплата марками
        /// </summary>
        [EnumMember(Value = "STAMP")]
        Stamp,

        /// <summary>
        /// Франкирование
        /// </summary>
        [EnumMember(Value = "FRANKING")]
        Franking,

        /// <summary>
        /// На франкировку
        /// </summary>
        [EnumMember(Value = "TO_FRANKING")]
        ToFranking,

        /// <summary>
        /// Знак онлайн оплаты
        /// </summary>
        [EnumMember(Value = "ONLINE_PAYMENT_MARK")]
        OnlinePaymentMark,
    }
}
