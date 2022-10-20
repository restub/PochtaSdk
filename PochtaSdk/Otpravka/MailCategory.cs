using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Mail category
    /// Категория отправления
    /// https://otpravka.pochta.ru/specification#/enums-base-mail-category
    /// </summary>
    [DataContract]
    public enum MailCategory
    {
        /// <summary>
        /// Простое
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        Simple,

        /// <summary>
        /// Заказное
        /// </summary>
        [EnumMember(Value = "ORDERED")]
        Ordered,
        Registered = Ordered,

        /// <summary>
        /// Обыкновенное
        /// </summary>
        [EnumMember(Value = "ORDINARY")]
        Ordinary,
        Regular = Ordinary,

        /// <summary>
        /// С объявленной ценностью
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE")]
        WithDeclaredValue,

        /// <summary>
        /// С объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        WithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// С объявленной ценностью и обязательным платежом
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE_AND_COMPULSORY_PAYMENT")]
        WithDeclaredValueAndCompulsoryPayment,

        /// <summary>
        /// С обязательным платежом
        /// </summary>
        [EnumMember(Value = "WITH_COMPULSORY_PAYMENT")]
        WithCompulsoryPayment,

        /// <summary>
        /// Комбинированное
        /// </summary>
        [EnumMember(Value = "COMBINED")]
        Combined,

        /// <summary>
        /// Комбинированное обыкновенное
        /// </summary>
        [EnumMember(Value = "COMBINED_ORDINARY")]
        CombinedOrdinary,

        /// <summary>
        /// Комбинированное с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "COMBINED_WITH_DECLARED_VALUE")]
        CombinedWithDeclaredValue,

        /// <summary>
        /// Комбинированное с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "COMBINED_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        CombinedWithDeclaredValueAndCashOnDelivery,
    }
}