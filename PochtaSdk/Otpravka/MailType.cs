using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Mail type
    /// Тип отправления
    /// https://otpravka.pochta.ru/specification#/enums-base-mail-type
    /// </summary>
    public enum MailType
    {
        /// <summary>
        /// Посылка нестандартная
        /// </summary>
        [EnumMember(Value = "POSTAL_PARCEL")]
        PostalParcel,

        /// <summary>
        /// Посылка онлайн
        /// </summary>
        [EnumMember(Value = "ONLINE_PARCEL")]
        OnlineParcel,

        /// <summary>
        /// Курьер онлайн
        /// </summary>
        [EnumMember(Value = "ONLINE_COURIER")]
        OnlineCourier,

        /// <summary>
        /// Отправление EMS
        /// </summary>
        [EnumMember(Value = "EMS")]
        Ems,

        /// <summary>
        /// EMS оптимальное
        /// </summary>
        [EnumMember(Value = "EMS_OPTIMAL")]
        EmsOptimal,

        /// <summary>
        /// EMS РТ
        /// </summary>
        [EnumMember(Value = "EMS_RT")]
        EmsRt,

        /// <summary>
        /// EMS тендер
        /// </summary>
        [EnumMember(Value = "EMS_TENDER")]
        EmsTender,

        /// <summary>
        /// Письмо
        /// </summary>
        [EnumMember(Value = "LETTER")]
        Letter,

        /// <summary>
        /// Письмо 1-го класса
        /// </summary>
        [EnumMember(Value = "LETTER_CLASS_1")]
        LetterClass1,

        /// <summary>
        /// Бандероль
        /// </summary>
        [EnumMember(Value = "BANDEROL")]
        Banderol,

        /// <summary>
        /// Бизнес курьер
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER")]
        BusinessCourier,

        /// <summary>
        /// Бизнес курьер экпресс
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_ES")]
        BusinessCourierExpress,

        /// <summary>
        /// Посылка 1-го класса
        /// </summary>
        [EnumMember(Value = "PARCEL_CLASS_1")]
        ParcelClass1,

        /// <summary>
        /// Бандероль 1-го класса
        /// </summary>
        [EnumMember(Value = "BANDEROL_CLASS_1")]
        BanderolClass1,

        /// <summary>
        /// ВГПО 1-го класса
        /// </summary>
        [EnumMember(Value = "VGPO_CLASS_1")]
        VgpoClass1,

        /// <summary>
        /// Мелкий пакет
        /// </summary>
        [EnumMember(Value = "SMALL_PACKET")]
        SmallPacket,

        /// <summary>
        /// Легкий возврат
        /// </summary>
        [EnumMember(Value = "EASY_RETURN")]
        EasyReturn,

        /// <summary>
        /// Отправление ВСД
        /// </summary>
        [EnumMember(Value = "VSD")]
        Vsd,

        /// <summary>
        /// ЕКОМ
        /// </summary>
        [EnumMember(Value = "ECOM")]
        Ecom,

        /// <summary>
        /// ЕКОМ Маркетплейс
        /// </summary>
        [EnumMember(Value = "ECOM_MARKETPLACE")]
        EcomMarketplace,

        /// <summary>
        /// Гипергруз
        /// </summary>
        [EnumMember(Value = "HYPER_CARGO")]
        HyperCargo,

        /// <summary>
        /// Комбинированное
        /// </summary>
        [EnumMember(Value = "COMBINED")]
        Combined,
    }
}
