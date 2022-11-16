using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Product type
    /// Тип продукта (комбинация типа и категории отправления)
    /// https://otpravka.pochta.ru/specification#/enums-product
    /// </summary>
    [DataContract]
    public enum ProductType
    {
        /// <summary>
        /// Заказное письмо
        /// </summary>
        [EnumMember(Value = "LETTER_ORDERED")]
        [Display(Name = "Заказное письмо")]
        LetterOrdered,

        /// <summary>
        /// Письмо с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "LETTER_WITH_DECLARED_VALUE")]
        [Display(Name = "Письмо с объявленной ценностью")]
        LetterWithDeclaredValue,

        /// <summary>
        /// Письмо с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "LETTER_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Письмо с объявленной ценностью и наложенным платежом")]
        LetterWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Международное заказное письмо
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_LETTER_ORDERED")]
        [Display(Name = "Международное заказное письмо")]
        InternationalLetterOrdered,

        /// <summary>
        /// Простая бандероль (консолидатор)
        /// </summary>
        [EnumMember(Value = "BANDEROL_SIMPLE")]
        [Display(Name = "Простая бандероль (консолидатор)")]
        BanderolSimple,

        /// <summary>
        /// Заказная бандероль
        /// </summary>
        [EnumMember(Value = "BANDEROL_ORDERED")]
        [Display(Name = "Заказная бандероль")]
        BanderolOrdered,

        /// <summary>
        /// Бандероль с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "BANDEROL_WITH_DECLARED_VALUE")]
        [Display(Name = "Бандероль с объявленной ценностью")]
        BanderolWithDeclaredValue,

        /// <summary>
        /// Бандероль с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "BANDEROL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Бандероль с объявленной ценностью и наложенным платежом")]
        BanderolWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Посылка обыкновенная
        /// </summary>
        [EnumMember(Value = "POSTAL_PARCEL_ORDINARY")]
        [Display(Name = "Посылка обыкновенная")]
        PostalParcelOrdinary,

        /// <summary>
        /// Посылка с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "POSTAL_PARCEL_WITH_DECLARED_VALUE")]
        [Display(Name = "Посылка с объявленной ценностью")]
        PostalParcelWithDeclaredValue,

        /// <summary>
        /// Посылка с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "POSTAL_PARCEL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Посылка с объявленной ценностью и наложенным платежом")]
        PostalParcelWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Посылка обыкновенная международная
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_POSTAL_PARCEL_ORDINARY")]
        [Display(Name = "Посылка обыкновенная международная")]
        InternationalPostalParcelOrdinary,

        /// <summary>
        /// EMS обыкновенное
        /// </summary>
        [EnumMember(Value = "EMS_ORDINARY")]
        [Display(Name = "EMS обыкновенное")]
        EmsOrdinary,

        /// <summary>
        /// EMS с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "EMS_WITH_DECLARED_VALUE")]
        [Display(Name = "EMS с объявленной ценностью")]
        EmsWithDeclaredValue,

        /// <summary>
        /// EMS с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "EMS_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "EMS с объявленной ценностью и наложенным платежом")]
        EmsWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// EMS оптимальное обыкновенное
        /// </summary>
        [EnumMember(Value = "EMS_OPTIMAL_ORDINARY")]
        [Display(Name = "EMS оптимальное обыкновенное")]
        EmsOptimalOrdinary,

        /// <summary>
        /// EMS оптимальное с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "EMS_OPTIMAL_WITH_DECLARED_VALUE")]
        [Display(Name = "EMS оптимальное с объявленной ценностью")]
        EmsOptimalWithDeclaredValue,

        /// <summary>
        /// EMS оптимальное с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "EMS_OPTIMAL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "EMS оптимальное с объявленной ценностью и наложенным платежом")]
        EmsOptimalWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// EMS РТ
        /// </summary>
        [EnumMember(Value = "EMS_RT_ORDINARY")]
        [Display(Name = "EMS РТ")]
        EmsRtOrdinary,

        /// <summary>
        /// EMS с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "EMS_RT_WITH_DECLARED_VALUE")]
        [Display(Name = "EMS с объявленной ценностью")]
        EmsRtWithDeclaredValue,

        /// <summary>
        /// Посылка онлайн обыкновенная
        /// </summary>
        [EnumMember(Value = "ONLINE_PARCEL_ORDINARY")]
        [Display(Name = "Посылка онлайн обыкновенная")]
        OnlineParcelOrdinary,

        /// <summary>
        /// Посылка онлайн с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "ONLINE_PARCEL_WITH_DECLARED_VALUE")]
        [Display(Name = "Посылка онлайн с объявленной ценностью")]
        OnlineParcelWithDeclaredValue,

        /// <summary>
        /// Посылка онлайн с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "ONLINE_PARCEL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Посылка онлайн с объявленной ценностью и наложенным платежом")]
        OnlineParcelWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Курьер онлайн обыкновенное
        /// </summary>
        [EnumMember(Value = "ONLINE_COURIER_ORDINARY")]
        [Display(Name = "Курьер онлайн обыкновенное")]
        OnlineCourierOrdinary,

        /// <summary>
        /// Курьер онлайн с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "ONLINE_COURIER_WITH_DECLARED_VALUE")]
        [Display(Name = "Курьер онлайн с объявленной ценностью")]
        OnlineCourierWithDeclaredValue,

        /// <summary>
        /// Курьер онлайн с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "ONLINE_COURIER_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Курьер онлайн с объявленной ценностью и наложенным платежом")]
        OnlineCourierWithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Бизнес Курьер обыкновненное
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_ORDINARY")]
        [Display(Name = "Бизнес Курьер обыкновненное")]
        BusinessCourierOrdinary,

        /// <summary>
        /// Бизнес Курьер с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_WITH_DECLARED_VALUE")]
        [Display(Name = "Бизнес Курьер с объявленной ценностью")]
        BusinessCourierWithDeclaredValue,

        /// <summary>
        /// Бизнес Курьер экспресс обыкновненное
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_ES_ORDINARY")]
        [Display(Name = "Бизнес Курьер экспресс обыкновненное")]
        BusinessCourierEsOrdinary,

        /// <summary>
        /// Бизнес Курьер экспресс с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_ES_WITH_DECLARED_VALUE")]
        [Display(Name = "Бизнес Курьер экспресс с объявленной ценностью")]
        BusinessCourierEsWithDeclaredValue,

        /// <summary>
        /// Посылка 1-го класса обыкновенная
        /// </summary>
        [EnumMember(Value = "PARCEL_CLASS_1_ORDINARY")]
        [Display(Name = "Посылка 1-го класса обыкновенная")]
        ParcelClass1Ordinary,

        /// <summary>
        /// Посылка 1-го класса с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "PARCEL_CLASS_1_WITH_DECLARED_VALUE")]
        [Display(Name = "Посылка 1-го класса с объявленной ценностью")]
        ParcelClass1WithDeclaredValue,

        /// <summary>
        /// Посылка 1-го класса с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "PARCEL_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Посылка 1-го класса с объявленной ценностью и наложенным платежом")]
        ParcelClass1WithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Письмо 1-го класса заказное
        /// </summary>
        [EnumMember(Value = "LETTER_CLASS_1_ORDERED")]
        [Display(Name = "Письмо 1-го класса заказное")]
        LetterClass1Ordered,

        /// <summary>
        /// Письмо 1-го класса с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "LETTER_CLASS_1_WITH_DECLARED_VALUE")]
        [Display(Name = "Письмо 1-го класса с объявленной ценностью")]
        LetterClass1WithDeclaredValue,

        /// <summary>
        /// Письмо 1-го класса с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "LETTER_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Письмо 1-го класса с объявленной ценностью и наложенным платежом")]
        LetterClass1WithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Бандероль 1 класса заказное
        /// </summary>
        [EnumMember(Value = "BANDEROL_CLASS_1_ORDERED")]
        [Display(Name = "Бандероль 1 класса заказное")]
        BanderolClass1Ordered,

        /// <summary>
        /// Бандероль 1 класса с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "BANDEROL_CLASS_1_WITH_DECLARED_VALUE")]
        [Display(Name = "Бандероль 1 класса с объявленной ценностью")]
        BanderolClass1WithDeclaredValue,

        /// <summary>
        /// Бандероль 1 класса с объявленной ценностью и наложенным платежом
        /// </summary>
        [EnumMember(Value = "BANDEROL_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY")]
        [Display(Name = "Бандероль 1 класса с объявленной ценностью и наложенным платежом")]
        BanderolClass1WithDeclaredValueAndCashOnDelivery,

        /// <summary>
        /// Письмо обыкновенное (консолидатор)
        /// </summary>
        [EnumMember(Value = "LETTER_SIMPLE")]
        [Display(Name = "Письмо обыкновенное (консолидатор)")]
        LetterSimple,

        /// <summary>
        /// Простое письмо единичное
        /// </summary>
        [EnumMember(Value = "SINGLE_LETTER_SIMPLE")]
        [Display(Name = "Простое письмо единичное")]
        SingleLetterSimple,

        /// <summary>
        /// Простая бандероль единичная
        /// </summary>
        [EnumMember(Value = "SINGLE_BANDEROL_SIMPLE")]
        [Display(Name = "Простая бандероль единичная")]
        SingleBanderolSimple,

        /// <summary>
        /// Мелкий пакет заказной
        /// </summary>
        [EnumMember(Value = "SMALL_PACKET_ORDERED")]
        [Display(Name = "Мелкий пакет заказной")]
        SmallPacketOrdered,

        /// <summary>
        /// EMS международное обыкновенное
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_EMS_ORDINARY")]
        [Display(Name = "EMS международное обыкновенное")]
        InternationalEmsOrdinary,

        /// <summary>
        /// Международное простое письмо
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_SINGLE_LETTER_SIMPLE")]
        [Display(Name = "Международное простое письмо")]
        InternationalSingleLetterSimple,

        /// <summary>
        /// ВГПО 1-го класса заказное
        /// </summary>
        [EnumMember(Value = "VGPO_CLASS_1_ORDERED")]
        [Display(Name = "ВГПО 1-го класса заказное")]
        VgpoClass1Ordered,

        /// <summary>
        /// ВГПО 1-го класса простое
        /// </summary>
        [EnumMember(Value = "VGPO_CLASS_1_SIMPLE")]
        [Display(Name = "ВГПО 1-го класса простое")]
        VgpoClass1Simple,

        /// <summary>
        /// EMS Тендер
        /// </summary>
        [EnumMember(Value = "EMS_TENDER_ORDINARY")]
        [Display(Name = "EMS Тендер")]
        EmsTenderOrdinary,

        /// <summary>
        /// EMS Тендер с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "EMS_TENDER_WITH_DECLARED_VALUE")]
        [Display(Name = "EMS Тендер с объявленной ценностью")]
        EmsTenderWithDeclaredValue,

        /// <summary>
        /// Отправление ВСД
        /// </summary>
        [EnumMember(Value = "VSD_ORDINARY")]
        [Display(Name = "Отправление ВСД")]
        VsdOrdinary,

        /// <summary>
        /// ЕКОМ обыкновенное
        /// </summary>
        [EnumMember(Value = "ECOM_ORDINARY")]
        [Display(Name = "ЕКОМ обыкновенное")]
        EcomOrdinary,

        /// <summary>
        /// ЕКОМ с обязательным платежом
        /// </summary>
        [EnumMember(Value = "ECOM_WITH_COMPULSORY_PAYMENT")]
        [Display(Name = "ЕКОМ с обязательным платежом")]
        EcomWithCompulsoryPayment,

        /// <summary>
        /// ЕКОМ Маркетплейс с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "ECOM_MARKETPLACE_WITH_DECLARED_VALUE")]
        [Display(Name = "ЕКОМ Маркетплейс с объявленной ценностью")]
        EcomMarketplaceWithDeclaredValue,

        /// <summary>
        /// Легкий возврат обыкновенное
        /// </summary>
        [EnumMember(Value = "EASY_RETURN_ORDINARY")]
        [Display(Name = "Легкий возврат обыкновенное")]
        EasyReturnOrdinary,

        /// <summary>
        /// Легкий возврат с объявленной ценностью
        /// </summary>
        [EnumMember(Value = "EASY_RETURN_WITH_DECLARED_VALUE")]
        [Display(Name = "Легкий возврат с объявленной ценностью")]
        EasyReturnWithDeclaredValue,
    }
}
