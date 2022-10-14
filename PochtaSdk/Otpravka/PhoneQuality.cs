using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Phone number normalization quality code.
    /// Код качества нормализации телефона.
    /// https://otpravka.pochta.ru/specification#/enums-clean-fio-phone-quality
    /// </summary>
    [DataContract]
    public enum PhoneQuality
    {
        /// <summary>
        /// Подтверждено контролером
        /// </summary>
        [EnumMember(Value = "CONFIRMED_MANUALLY")]
        ConfirmedManually,

        /// <summary>
        /// Корректный телефонный номер
        /// </summary>
        [EnumMember(Value = "GOOD")]
        Good,

        /// <summary>
        /// Изменен код телефонного номера
        /// </summary>
        [EnumMember(Value = "GOOD_REPLACED_CODE")]
        GoodReplacedCode,

        /// <summary>
        /// Изменен номер телефона
        /// </summary>
        [EnumMember(Value = "GOOD_REPLACED_NUMBER")]
        GoodReplacedNumber,

        /// <summary>
        /// Изменен код и номер телефона
        /// </summary>
        [EnumMember(Value = "GOOD_REPLACED_CODE_NUMBER")]
        GoodReplacedCodeNumber,

        /// <summary>
        /// Конфликт по городу
        /// </summary>
        [EnumMember(Value = "GOOD_CITY_CONFLICT")]
        GoodCityConflict,

        /// <summary>
        /// Конфликт по региону
        /// </summary>
        [EnumMember(Value = "GOOD_REGION_CONFLICT")]
        GoodRegionConflict,

        /// <summary>
        /// Иностранный телефонный номер
        /// </summary>
        [EnumMember(Value = "FOREIGN")]
        Foreign,

        /// <summary>
        /// Неоднозначный код телефонного номера
        /// </summary>
        [EnumMember(Value = "CODE_AMBI")]
        CodeAmbiguous,

        /// <summary>
        /// Пустой телефонный номер
        /// </summary>
        [EnumMember(Value = "EMPTY")]
        Empty,

        /// <summary>
        /// Телефонный номер содержит некорректные символы
        /// </summary>
        [EnumMember(Value = "GARBAGE")]
        Garbage,

        /// <summary>
        /// Восстановлен город в телефонном номере
        /// </summary>
        [EnumMember(Value = "GOOD_CITY")]
        GoodCity,

        /// <summary>
        /// Запись содержит более одного телефона
        /// </summary>
        [EnumMember(Value = "GOOD_EXTRA_PHONE")]
        GoodExtraPhone,

        /// <summary>
        /// Телефон не может быть распознан
        /// </summary>
        [EnumMember(Value = "UNDEF")]
        Undefined,

        /// <summary>
        /// Телефон не может быть распознан
        /// </summary>
        [EnumMember(Value = "INCORRECT_DATA")]
        IncorrectData,
    }
}
