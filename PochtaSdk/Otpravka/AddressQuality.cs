using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address normalization quality code.
    /// Код качества нормализации адреса.
    /// https://otpravka.pochta.ru/specification#/enums-clean-address-quality
    /// </summary>
    [DataContract]
    public enum AddressQuality
    {
        /// <summary>
        /// Пригоден для почтовой рассылки
        /// </summary>
        [EnumMember(Value = "GOOD")]
        Good,

        /// <summary>
        /// До востребования
        /// </summary>
        [EnumMember(Value = "ON_DEMAND")]
        OnDemand,

        /// <summary>
        /// Абонентский ящик
        /// </summary>
        [EnumMember(Value = "POSTAL_BOX")]
        PostalBox,

        /// <summary>
        /// Не определен регион
        /// </summary>
        [EnumMember(Value = "UNDEF_01")]
        RegionNotDefined,

        /// <summary>
        /// Не определен город или населенный пункт
        /// </summary>
        [EnumMember(Value = "UNDEF_02")]
        CityNotDefined,

        /// <summary>
        /// Не определена улица
        /// </summary>
        [EnumMember(Value = "UNDEF_03")]
        StreetNotDefined,

        /// <summary>
        /// Не определен номер дома
        /// </summary>
        [EnumMember(Value = "UNDEF_04")]
        HouseNotDefined,

        /// <summary>
        /// Не определена квартира/офис
        /// </summary>
        [EnumMember(Value = "UNDEF_05")]
        RoomNotDefined,

        /// <summary>
        /// Не определен
        /// </summary>
        [EnumMember(Value = "UNDEF_06")]
        NotDefined,

        /// <summary>
        /// Иностранный адрес
        /// </summary>
        [EnumMember(Value = "UNDEF_07")]
        ForeignAddress,
    }
}