using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Full name normalization quality code.
    /// Код качества нормализации ФИО.
    /// https://otpravka.pochta.ru/specification#/enums-clean-fio-quality
    /// </summary>
    [DataContract]
    public enum FullNameQuality
    {
        /// <summary>
        /// Подтверждено контролером
        /// </summary>
        [EnumMember(Value = "CONFIRMED_MANUALLY")]
        ConfirmedManually,

        /// <summary>
        /// Правильное значение
        /// </summary>
        [EnumMember(Value = "EDITED")]
        Edited,

        /// <summary>
        /// Сомнительное значение
        /// </summary>
        [EnumMember(Value = "NOT_SURE")]
        NotSure,
    }
}