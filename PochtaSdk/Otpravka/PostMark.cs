using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post marks for the domestic and international shippings
    /// Коды отметок внутренних и международных отправлений
    /// https://otpravka.pochta.ru/specification#/enums-base-transport-type
    /// </summary>
    [DataContract]
    public enum PostMark
    {
        /// <summary>
        /// Без отметки
        /// </summary>
        [EnumMember(Value = "WITHOUT_MARK")]
        WithoutMark,

        /// <summary>
        /// С простым уведомлением
        /// </summary>
        [EnumMember(Value = "WITH_SIMPLE_NOTICE")]
        WithSimpleNotice,

        /// <summary>
        /// С заказным уведомлением
        /// </summary>
        [EnumMember(Value = "WITH_ORDER_OF_NOTICE")]
        WithOrderOfNotice,
        WithRegisteredNotice = WithOrderOfNotice,

        /// <summary>
        /// С описью
        /// </summary>
        [EnumMember(Value = "WITH_INVENTORY")]
        WithInventory,

        /// <summary>
        /// Осторожно (Хрупкая)
        /// </summary>
        [EnumMember(Value = "CAUTION_FRAGILE")]
        CautionFragile,

        /// <summary>
        /// Тяжеловесная
        /// </summary>
        [EnumMember(Value = "HEAVY_HANDED")]
        HeavyHanded,

        /// <summary>
        /// Крупногабаритная (Громоздкая)
        /// </summary>
        [EnumMember(Value = "LARGE_BULKY")]
        LargeBulky,

        /// <summary>
        /// С доставкой (Доставка нарочным)
        /// </summary>
        [EnumMember(Value = "WITH_DELIVERY")]
        WithDelivery,

        /// <summary>
        /// Вручить в собственные руки
        /// </summary>
        [EnumMember(Value = "AWARDED_IN_OWN_HANDS")]
        AwardedInOwnHands,

        /// <summary>
        /// С документами
        /// </summary>
        [EnumMember(Value = "WITH_DOCUMENTS")]
        WithDocuments,

        /// <summary>
        /// С товарами
        /// </summary>
        [EnumMember(Value = "WITH_GOODS")]
        WithGoods,

        /// <summary>
        /// Возврату не подлежит
        /// </summary>
        [EnumMember(Value = "NO_RETURN")]
        NoReturn,

        /// <summary>
        /// Нестандартная
        /// </summary>
        [EnumMember(Value = "NONSTANDARD")]
        NonStandard,

        /// <summary>
        /// С ОЦ
        /// </summary>
        [EnumMember(Value = "INSURED")]
        Insured,

        /// <summary>
        /// С электронным уведомлением
        /// </summary>
        [EnumMember(Value = "WITH_ELECTRONIC_NOTIFICATION")]
        WithElectronicNotification,

        /// <summary>
        /// Курьер бизнес-экспресс
        /// </summary>
        [EnumMember(Value = "BUSINESS_COURIER_EXPRESS")]
        BusinessCourierExpress,

        /// <summary>
        /// Нестандартная до 10 кг
        /// </summary>
        [EnumMember(Value = "NONSTANDARD_UPTO_10KG")]
        NonStandardUpTo10KG,

        /// <summary>
        /// Нестандартная до 20 кг
        /// </summary>
        [EnumMember(Value = "NONSTANDARD_UPTO_20KG")]
        NonStandardUpTo20KG,

        /// <summary>
        /// С наложенным платежом
        /// </summary>
        [EnumMember(Value = "WITH_CASH_ON_DELIVERY")]
        WithCashOnDelivery,

        /// <summary>
        /// Гарантия сохранности
        /// </summary>
        [EnumMember(Value = "SAFETY_GUARANTEE")]
        SafetyGuarantee,

        /// <summary>
        /// Заверительный пакет
        /// </summary>
        [EnumMember(Value = "ASSURE_PACKAGE")]
        AssurePackage,

        /// <summary>
        /// Доставка курьером
        /// </summary>
        [EnumMember(Value = "COURIER_DELIVERY")]
        CourierDelivery,

        /// <summary>
        /// Проверка комплектности
        /// </summary>
        [EnumMember(Value = "COMPLETENESS_CHECKING")]
        CompletenessChecking,

        /// <summary>
        /// Негабаритная
        /// </summary>
        [EnumMember(Value = "OVERSIZED")]
        Oversized,

        /// <summary>
        /// В упаковке Почты России
        /// </summary>
        [EnumMember(Value = "RUPOST_PACKAGE")]
        RupostPackage,

        /// <summary>
        /// Оплата при получении
        /// </summary>
        [EnumMember(Value = "DELIVERY_WITH_COD")]
        DeliveryWithCod,

        /// <summary>
        /// Возврат сопроводительных документов
        /// </summary>
        [EnumMember(Value = "VSD")]
        Vsd,

        /// <summary>
        /// Легкий возврат
        /// </summary>
        [EnumMember(Value = "EASY_RETURN")]
        EasyReturn,
    }
}
