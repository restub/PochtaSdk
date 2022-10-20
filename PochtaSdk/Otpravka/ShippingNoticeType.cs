using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping notice type
    /// Категория уведомления о вручении РПО
    /// https://otpravka.pochta.ru/specification#/enums-base-notify-category
    /// </summary>
    [DataContract]
    public enum ShippingNoticeType
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
        /// Электронное
        /// </summary>
        [EnumMember(Value = "ELECTRONIC")]
        Electronic,
    }
}