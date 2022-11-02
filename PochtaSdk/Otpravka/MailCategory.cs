using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Простое")]
        Simple,

        /// <summary>
        /// Заказное
        /// </summary>
        [EnumMember(Value = "ORDERED")]
        [Display(Name = "Заказное")]
        Ordered,

        /// <summary>
        /// Обыкновенное
        /// </summary>
        [EnumMember(Value = "ORDINARY")]
        [Display(Name = "Обыкновенное")]
        Ordinary,

        /// <summary>
        /// С объявленной ценностью
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE")]
        [Display(Name = "С объявленной ценностью")]
        WithDeclaredValue,

        /// <summary>
        /// С объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "С объявленной ценностью и наложенным платежом")]
        WithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// С объявленной ценностью и обязательным платежом
        /// </summary>
        [EnumMember(Value = "WITH_DECLARED_VALUE_AND_COMPULSORY_PAYMENT")]
        [Display(Name = "С объявленной ценностью и обязательным платежом")]
        WithDeclaredValueAndCompulsoryPayment,

        /// <summary>
        /// С обязательным платежом
        /// </summary>
        [EnumMember(Value = "WITH_COMPULSORY_PAYMENT")]
        [Display(Name = "С обязательным платежом")]
        WithCompulsoryPayment,

        /// <summary>
        /// Комбинированное
        /// </summary>
        [EnumMember(Value = "COMBINED")]
        [Display(Name = "Комбинированное")]
        Combined,

        /// <summary>
        /// Комбинированное обыкновенное
        /// </summary>
        [EnumMember(Value = "COMBINED_ORDINARY")]
        [Display(Name = "Комбинированное обыкновенное")]
        CombinedOrdinary,

        /// <summary>
        /// Комбинированное с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "COMBINED_WITH_DECLARED_VALUE")]
        [Display(Name = "Комбинированное с объявленной ценностью")]
        CombinedWithDeclaredValue,

        /// <summary>
        /// Комбинированное с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "COMBINED_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Комбинированное с объявленной ценностью и наложенным платежом")]
        CombinedWithDeclaredValueAndCashOnDelivery,
    }
}