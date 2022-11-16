using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Return address type
    /// Тип адреса возврата
    /// https://otpravka.pochta.ru/specification#/settings-shipping_points
    /// </summary>
    /// <remarks>
    /// Недокументированное перечисление
    /// </remarks>
    [DataContract, DefaultEnumMember(Unknown)]
    public enum ReturnAddressType
    {
        /// <summary>
        /// Значение неизвестно
        /// </summary>
        Unknown,

        /// <summary>
        /// Адрес возврата — это адрес отделения
        /// </summary>
        [EnumMember(Value = "POSTOFFICE_ADDRESS")]
        [Display(Name = "Адрес отделения")]
        PostOfficeAddress,
    }
}
