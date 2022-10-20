using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch status.
    /// Статусы партии.
    /// https://otpravka.pochta.ru/specification#/enums-base-batch-status
    /// </summary>
    [DataContract]
    public enum BatchStatus
    {
        /// <summary>
        /// Партия создана
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// Партия в процессе приема, редактирование запрещено
        /// </summary>
        [EnumMember(Value = "FROZEN")]
        Frozen,

        /// <summary>
        /// Партия принята в отделении связи
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        Accepted,

        /// <summary>
        /// По заказам в партии существуют данные в сервисе трекинга
        /// </summary>
        [EnumMember(Value = "SENT")]
        Sent,

        /// <summary>
        /// Партия находится в архиве
        /// </summary>
        [EnumMember(Value = "ARCHIVED")]
        Archived,
    }
}