using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Mail type
    /// Тип отправления
    /// https://otpravka.pochta.ru/specification#/enums-base-mail-type
    /// </summary>
    [DataContract]
    public enum MailType
    {
        /// <summary>
        /// Посылка нестандартная
        /// </summary>
        [EnumMember(Value = "POSTAL_PARCEL")]
        [Display(Name = "Посылка нестандартная")]
        PostalParcel,

        /// <summary>
        /// Посылка онлайн
        /// </summary>
        [EnumMember(Value = "ONLINE_PARCEL")]
        [Display(Name = "Посылка онлайн")]
        OnlineParcel,

        /// <summary>
        /// Курьер онлайн
        /// </summary>
        [EnumMember(Value = "ONLINE_COURIER")]
        [Display(Name = "Курьер онлайн")]
        OnlineCourier,

        /// <summary>
        /// Отправление EMS
        /// </summary>
        [EnumMember(Value = "EMS")]
        [Display(Name = "Отправление EMS")]
        Ems,

        /// <summary>
        /// EMS оптимальное
        /// </summary>
        [EnumMember(Value = "EMS_OPTIMAL")]
        [Display(Name = "EMS оптимальное")]
        EmsOptimal,

        /// <summary>
        /// EMS РТ
        /// </summary>
        [EnumMember(Value = "EMS_RT")]
        [Display(Name = "EMS РТ")]
        EmsRt,

        /// <summary>
        /// EMS тендер
        /// </summary>
        [EnumMember(Value = "EMS_TENDER")]
        [Display(Name = "EMS тендер")]
        EmsTender,

        /// <summary>
        /// Письмо
        /// </summary>
        [EnumMember(Value = "LETTER")]
        [Display(Name = "Письмо")]
        Letter,

        /// <summary>
        /// Письмо 1-го класса
        /// </summary>
        [EnumMember(Value = "LETTER_CLASS_1")]
        [Display(Name = "Письмо 1-го класса")]
        LetterClass1,

        /// <summary>
        /// Бандероль
        /// </summary>
        [EnumMember(Value = "BANDEROL")]
        [Display(Name = "Бандероль")]
        Banderol,

        /// <summary>
        /// Бизнес курьер
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER")]
        [Display(Name = "Бизнес курьер")]
        BusinessCourier,

        /// <summary>
        /// Бизнес курьер экпресс
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_ES")]
        [Display(Name = "Бизнес курьер экпресс")]
        BusinessCourierExpress,

        /// <summary>
        /// Посылка 1-го класса
        /// </summary>
        [EnumMember(Value = "PARCEL_CLASS_1")]
        [Display(Name = "Посылка 1-го класса")]
        ParcelClass1,

        /// <summary>
        /// Бандероль 1-го класса
        /// </summary>
        [EnumMember(Value = "BANDEROL_CLASS_1")]
        [Display(Name = "Бандероль 1-го класса")]
        BanderolClass1,

        /// <summary>
        /// ВГПО 1-го класса
        /// </summary>
        [EnumMember(Value = "VGPO_CLASS_1")]
        [Display(Name = "ВГПО 1-го класса")]
        VgpoClass1,

        /// <summary>
        /// Мелкий пакет
        /// </summary>
        [EnumMember(Value = "SMALL_PACKET")]
        [Display(Name = "Мелкий пакет")]
        SmallPacket,

        /// <summary>
        /// Легкий возврат
        /// </summary>
        /// <remarks>
        /// В документации такая константа есть, но попытка расчета тарифов ругается:
        /// No enum constant ru.russianpost.iplatform.dictionary.ShipmentBatchType.EASY_RETURN
        /// </remarks>
        [EnumMember(Value = "EASY_RETURN")]
        [Display(Name = "Легкий возврат")]
        EasyReturn,

        /// <summary>
        /// Отправление ВСД
        /// </summary>
        [EnumMember(Value = "VSD")]
        [Display(Name = "Отправление ВСД")]
        Vsd,

        /// <summary>
        /// ЕКОМ
        /// </summary>
        [EnumMember(Value = "ECOM")]
        [Display(Name = "ЕКОМ")]
        Ecom,

        /// <summary>
        /// ЕКОМ Маркетплейс
        /// </summary>
        [EnumMember(Value = "ECOM_MARKETPLACE")]
        [Display(Name = "ЕКОМ Маркетплейс")]
        EcomMarketplace,

        /// <summary>
        /// Гипергруз
        /// </summary>
        [EnumMember(Value = "HYPER_CARGO")]
        [Display(Name = "Гипергруз")]
        HyperCargo,

        /// <summary>
        /// Комбинированное
        /// </summary>
        [EnumMember(Value = "COMBINED")]
        [Display(Name = "Комбинированное")]
        Combined,
    }
}
