using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Customs declarations statuses.
    /// Результат электронного декларирования.
    /// https://otpravka.pochta.ru/specification#/enums-declaration-status
    /// </summary>
    [DataContract]
    public enum CustomsDeclarationStatus
    {
        /// <summary>
        /// New
        /// Новая
        /// </summary>
        [EnumMember(Value = "NEW")]
        New,

        /// <summary>
        /// Transit
        /// Отправлено на декларирование
        /// </summary>
        [EnumMember(Value = "TRANSIT")]
        Transit,

        /// <summary>
        /// In progress
        /// Направлено в ФТС. Для подписания перейдите по ссылке:
        /// https://web2.edata.customs.ru/FtsPersonalCabinetWeb2017/#?view=List&amp;service=MpoNds
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        /// Done
        /// Разрешен выпуск товаров без уплаты таможенных платежей
        /// </summary>
        [EnumMember(Value = "DONE")]
        Done,

        /// <summary>
        /// Rejected
        /// Отказ в выпуске товаров
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        Rejected,

        /// <summary>
        /// Canceled
        /// Декларирование отменено
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled,

        /// <summary>
        /// Illegal data
        /// Ошибка декларирования
        /// </summary>
        [EnumMember(Value = "ILLEGAL_DATA")]
        IllegalData,

        /// <summary>
        /// FTS error
        /// Отправить на декларирование не удалось. Повторите попытку позднее.
        /// </summary>
        [EnumMember(Value = "FTS_ERROR")]
        FtsError,
    }
}
