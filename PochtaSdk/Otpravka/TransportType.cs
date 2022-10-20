using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Transport type
    /// Вид транспортировки
    /// https://otpravka.pochta.ru/specification#/enums-base-transport-type
    /// </summary>
    [DataContract]
    public enum TransportType
    {
        /// <summary>
        /// Наземный
        /// </summary>
        [EnumMember(Value = "SURFACE")]
        Surface,

        /// <summary>
        /// Авиа
        /// </summary>
        [EnumMember(Value = "AVIA")]
        Avia,

        /// <summary>
        /// Комбинированный
        /// </summary>
        [EnumMember(Value = "COMBINED")]
        Combined,

        /// <summary>
        /// Системой ускоренной почты
        /// </summary>
        [EnumMember(Value = "EXPRESS")]
        Express,

        /// <summary>
        /// Используется для отправлений "EMS Оптимальное"
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        Standard,
    }
}
