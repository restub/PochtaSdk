using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address type.
    /// Тип адреса.
    /// https://otpravka.pochta.ru/specification#/enums-base-address-type
    /// </summary>
    [DataContract]
    public enum AddressType
    {
        /// <summary>
        /// Стандартный (улица, дом, квартира)
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        Default,

        /// <summary>
        /// Абонентский ящик
        /// </summary>
        [EnumMember(Value = "PO_BOX")]
        PoBox,

        /// <summary>
        /// До востребования
        /// </summary>
        [EnumMember(Value = "DEMAND")]
        Demand,

        /// <summary>
        /// Для военных частей
        /// </summary>
        [EnumMember(Value = "UNIT")]
        Unit,
    }
}
