using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Identity methods.
    /// Методы идентификации.
    /// https://otpravka.pochta.ru/specification#/enums-identity-methods
    /// </summary>
    [DataContract]
    public enum IdentityMethod
    {
        /// <summary>
        /// Без идентификации
        /// </summary>
        [EnumMember(Value = "WITHOUT_IDENTIFICATION")]
        [Display(Name = "Без идентификации")]
        WithoutIdentification,

        /// <summary>
        /// Пин код (для почтоматов и партнерских ПВЗ)
        /// </summary>
        [EnumMember(Value = "PIN")]
        [Display(Name = "Пин код (для почтоматов и партнерских ПВЗ)")]
        Pin,

        /// <summary>
        /// Документ, удостоверяющий личность
        /// </summary>
        [EnumMember(Value = "IDENTITY_DOCUMENT")]
        [Display(Name = "Документ, удостоверяющий личность")]
        IdentityDocument,

        /// <summary>
        /// Номер заказа и ФИО (для отделений почтовой связи)
        /// </summary>
        [EnumMember(Value = "ORDER_NUM_AND_FIO")]
        [Display(Name = "Номер заказа и ФИО (для отделений почтовой связи)")]
        OrderNumberAndFullName,
    }
}
