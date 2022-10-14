using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address normalization validation code.
    /// Код проверки нормализации адреса.
    /// https://otpravka.pochta.ru/specification#/enums-clean-address-validation
    /// </summary>
    [DataContract]
    public enum AddressValidation
    {
        /// <summary>
        /// Подтверждено контролером
        /// </summary>
        [EnumMember(Value = "CONFIRMED_MANUALLY")]
        ConfirmedManually,

        /// <summary>
        /// Уверенное распознавание
        /// </summary>
        [EnumMember(Value = "VALIDATED")]
        Validated,

        /// <summary>
        /// Распознан: адрес был перезаписан в справочнике
        /// </summary>
        [EnumMember(Value = "OVERRIDDEN")]
        Overridder,

        /// <summary>
        /// На проверку, неразобранные части
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_UNPARSED_PARTS")]
        NotValidatedHasUnparsedParts,

        /// <summary>
        /// На проверку, предположение
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_ASSUMPTION")]
        NotValidatedHasAssumption,

        /// <summary>
        /// На проверку, нет основных частей
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_NO_MAIN_POINTS")]
        NotValidatedHasNoMainPoint,

        /// <summary>
        /// На проверку, предположение по улице
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_NUMBER_STREET_ASSUMPTION")]
        NotValidatedHasNumberStreetAssumption,

        /// <summary>
        /// На проверку, нет в КЛАДР
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_NO_KLADR_RECORD")]
        NotValidatedHasNoKladrRecord,

        /// <summary>
        /// На проверку, нет улицы или населенного пункта
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HOUSE_WITHOUT_STREET_OR_NP")]
        NotValidatedHouseWithoutStreet,

        /// <summary>
        /// На проверку, нет дома
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HOUSE_EXTENSION_WITHOUT_HOUSE")]
        NotValidatedHouseExtensionWithoutHouse,

        /// <summary>
        /// На проверку, неоднозначность
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_HAS_AMBI")]
        NotValidatedHasAmbiguity,

        /// <summary>
        /// На проверку, большой номер дома
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_EXCEDED_HOUSE_NUMBER")]
        NotValidatedExceededHouseNumber,

        /// <summary>
        /// На проверку, некорректный дом
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_INCORRECT_HOUSE")]
        NotValidatedIncorrectHouse,

        /// <summary>
        /// На проверку, некорректное расширение дома
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_INCORRECT_HOUSE_EXTENSION")]
        NotValidatedIncorrectHouseExtension,

        /// <summary>
        /// Иностранный адрес
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_FOREIGN")]
        NotValidatedForeignAddress,

        /// <summary>
        /// На проверку, не по справочнику
        /// </summary>
        [EnumMember(Value = "NOT_VALIDATED_DICTIONARY")]
        NotValidatedDictionary,
    }
}
