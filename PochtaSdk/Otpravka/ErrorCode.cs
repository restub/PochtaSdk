using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error codes.
    /// Коды ошибок.
    /// https://otpravka.pochta.ru/specification#/enums-base-envelope-type
    /// </summary>
    [DataContract, DefaultEnumMember(Undefined)]
    public enum ErrorCode
    {
        /// <summary>
        /// Все отправления уже отправлены
        /// </summary>
        [EnumMember(Value = "ALL_SHIPMENTS_SENT")]
        AllShipmentsSent,

        /// <summary>
        /// Ошибка при получении ШПИ
        /// </summary>
        [EnumMember(Value = "BARCODE_ERROR")]
        BarcodeError,

        /// <summary>
        /// Тип адреса не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_ADDRESS_TYPE_TO")]
        EmptyAddressTypeTo,

        /// <summary>
        /// Почтовый индекс не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_INDEX_TO")]
        EmptyPostCodeTo,

        /// <summary>
        /// Объявленная сумма не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_INSR_VALUE")]
        EmptyDeclaredValue,

        /// <summary>
        /// Категория почтового отправления не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_CATEGORY")]
        EmptyMailCategory,

        /// <summary>
        /// Почтовое направление не указано
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_DIRECT")]
        EmptyMailDirect,

        /// <summary>
        /// Тип почтового отправления не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_TYPE")]
        EmptyMailType,

        /// <summary>
        /// Масса не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_MASS")]
        EmptyMass,

        /// <summary>
        /// Не задан номер для соответствующего типа адреса
        /// </summary>
        [EnumMember(Value = "EMPTY_NUM_ADDRESS_TYPE")]
        EmptyNumAddressType,

        /// <summary>
        /// Наложенный платеж не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_PAYMENT")]
        EmptyPayment,

        /// <summary>
        /// Населенный пункт не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_PLACE_TO")]
        EmptyPlaceTo,

        /// <summary>
        /// Регион не заполнен
        /// </summary>
        [EnumMember(Value = "EMPTY_REGION_TO")]
        EmptyRegionTo,

        /// <summary>
        /// Способ пересылки не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_TRANSPORT_TYPE")]
        EmptyTransportType,

        /// <summary>
        /// Индекс приемного почтового отделения не задан
        /// </summary>
        [EnumMember(Value = "EMPTY_POSTOFFICE_CODE")]
        EmptyPostOfficeCode,

        /// <summary>
        /// Тип адреса некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_TYPE_TO")]
        IllegalAddressTypeTo,

        /// <summary>
        /// Почтовый индекс некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INDEX_TO")]
        IllegalPostCodeTo,

        /// <summary>
        /// ФИО некорректно
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INITIALS")]
        IllegalInitials,

        /// <summary>
        /// Объявленная сумма некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INSR_VALUE")]
        IllegalDeclaredValue,

        /// <summary>
        /// Категория почтового отправления некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_CATEGORY")]
        IllegalMailCategory,

        /// <summary>
        /// Почтовое направление некорректно
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_DIRECT")]
        IllegalMailDirect,

        /// <summary>
        /// Тип почтового отправления некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_TYPE")]
        IllegalMailType,

        /// <summary>
        /// Масса некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MASS")]
        IllegalMass,

        /// <summary>
        /// Вес отправления не должен превышать N кг
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MASS_EXCESS")]
        IllegalMassExcess,

        /// <summary>
        /// Наложенный платеж некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_PAYMENT")]
        IllegalPayment,

        /// <summary>
        /// Индекс приемного почтового отделения в настройках и в партии отличаются
        /// </summary>
        [EnumMember(Value = "ILLEGAL_POSTCODE")]
        IllegalPostCode,

        /// <summary>
        /// Индекс приемного почтового отделения некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_POSTOFFICE_CODE")]
        IllegalPostOfficeCode,

        /// <summary>
        /// Некорректный способ пересылки
        /// </summary>
        [EnumMember(Value = "ILLEGAL_TRANSPORT_TYPE")]
        IllegalTransportType,

        /// <summary>
        /// Ошибка имперсонализации
        /// </summary>
        [EnumMember(Value = "IMP13N_ERROR")]
        Imp13nError,

        /// <summary>
        /// Превышено максимальное значение N руб
        /// </summary>
        [EnumMember(Value = "INSR_VALUE_EXCEEDS_MAX")]
        DeclaredValueExceedsMax,

        /// <summary>
        /// Нет доступных точек сдачи
        /// </summary>
        [EnumMember(Value = "NO_AVAILABLE_POSTOFFICES")]
        NoAvailablePostOffices,

        /// <summary>
        /// Отправление не найдено
        /// </summary>
        [EnumMember(Value = "NOT_FOUND")]
        NotFound,

        /// <summary>
        /// Дата отправки просрочена
        /// </summary>
        [EnumMember(Value = "PAST_DUE_DATE")]
        PastDueDate,

        /// <summary>
        /// Изменения в партии недопустимы
        /// </summary>
        [EnumMember(Value = "READONLY_STATE")]
        ReadOnlyState,

        /// <summary>
        /// Для создания отправлений с наложенным платежом необходимо указать номер ЕСПП в настройках сервиса. Обратитесь к вашему персональному менеджеру в Почте или напишите письмо на почтовый ящик support.otpravka@russianpost.ru
        /// </summary>
        [EnumMember(Value = "RESTRICTED_MAIL_CATEGORY")]
        RestrictedMailCategory,

        /// <summary>
        /// Ошибка при отправке почты
        /// </summary>
        [EnumMember(Value = "SENDING_MAIL_FAILED")]
        SendingMailFailed,

        /// <summary>
        /// Ошибка при расчете тарифа
        /// </summary>
        [EnumMember(Value = "TARIFF_ERROR")]
        TariffError,

        /// <summary>
        /// Способы пересылки отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_TRANSPORT_TYPE")]
        DifferentTransportType,

        /// <summary>
        /// Типы почтовых отправлений не совпадают
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_TYPE")]
        DifferentMailType,

        /// <summary>
        /// Категории почтовых отправления не совпадают
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_CATEGORY")]
        DifferentMailCategory,

        /// <summary>
        /// Разряд отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_RANK")]
        DifferentMailRank,

        /// <summary>
        /// Отправление не может быть добавлено в партию с отметкой "Негабаритная"
        /// </summary>
        [EnumMember(Value = "ABSENT_OVERSIZE_POSTMARK")]
        AbsentOversizePostMark,

        /// <summary>
        /// Негабаритное отправление не может быть добавлено в партию без отметки "Негабаритная"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_OVERSIZE_POSTMARK")]
        UnexpectedOversizePostMark,

        /// <summary>
        /// Отправление без отметки "Осторожно/Хрупкое" не может быть добавлено в партию с отметкой "Осторожно/Хрупкое"
        /// </summary>
        [EnumMember(Value = "ABSENT_FRAGILE_POSTMARK")]
        AbsentFragilePostMark,

        /// <summary>
        /// Отправление с отметкой "Осторожно/Хрупкое" не может быть добавлено в партию без отметки "Осторожно/Хрупкое"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_FRAGILE_POSTMARK")]
        UnexpectedFragilePostMark,

        /// <summary>
        /// Отправление без отметки "Курьер" не может быть добавлено в партию с отметкой "Курьер"
        /// </summary>
        [EnumMember(Value = "ABSENT_COURIER_DELIVERY_POSTMARK")]
        AbsentCourierDeliveryPostMark,

        /// <summary>
        /// Отправление с отметкой "Курьер" не может быть добавлено в партию без отметки "Курьер"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_COURIER_DELIVERY_POSTMARK")]
        UnexpectedCourierDeliveryPostMark,

        /// <summary>
        /// Отправление без отметки "С заказным уведомлением" не может быть добавлено в партию с отметкой "С заказным уведомлением"
        /// </summary>
        [EnumMember(Value = "ABSENT_ORDER_OF_NOTICE_POSTMARK")]
        AbsentOrderOfNoticePostMark,

        /// <summary>
        /// Отправление с отметкой "С заказным уведомлением" не может быть добавлено в партию без отметки "С заказным уведомлением"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_ORDER_OF_NOTICE_POSTMARK")]
        UnexpectedOrderOfNoticePostMark,

        /// <summary>
        /// Отправление без отметки "С простым уведомлением" не может быть добавлено в партию с отметкой "С простым уведомлением"
        /// </summary>
        [EnumMember(Value = "ABSENT_SIMPLE_NOTICE_POSTMARK")]
        AbsentSimpleNoticePostMark,

        /// <summary>
        /// Отправление с отметкой "С простым уведомлением" не может быть добавлено в партию без отметки "С простым уведомлением"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_SIMPLE_NOTICE_POSTMARK")]
        UnexpectedSimpleNoticePostMark,

        /// <summary>
        /// Неопределенная ошибка
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Нарушение доступа
        /// </summary>
        [EnumMember(Value = "ACCESS_VIOLATION")]
        AccessViolation,

        /// <summary>
        /// Отправление уже отправлено
        /// </summary>
        [EnumMember(Value = "DELIVERY_IN_PROGRESS")]
        DeliveryInProgress,

        /// <summary>
        /// Телефон получателя является обязательным для данного вида отправления
        /// </summary>
        [EnumMember(Value = "EMPTY_TELADDRESS")]
        EmptyTelAddress,

        /// <summary>
        /// Наложенный платеж превышает объявленную ценность
        /// </summary>
        [EnumMember(Value = "NOT_INSURED_PAYMENT")]
        NotInsuredPayment,

        /// <summary>
        /// Способы пересылки отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_POSTCODE")]
        DifferentPostCode,

        /// <summary>
        /// Отметка "Осторожно/Хрупкое" неприменима для указанного типа отправлений
        /// </summary>
        [EnumMember(Value = "ILLEGAL_FRAGILE")]
        IllegalFragile,

        /// <summary>
        /// Код разряда почтового отправления не задан в настройках пользователя
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_RANK")]
        EmptyMailRank,

        /// <summary>
        /// Не задан тип конверта
        /// </summary>
        [EnumMember(Value = "EMPTY_ENVELOPE_TYPE")]
        EmptyEnvelopeType,

        /// <summary>
        /// Недопустимое значение "Тип конверта" для выбранного вида отправления
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ENVELOPE_TYPE")]
        IllegalEnvelopeType,

        /// <summary>
        /// Недопустимое значение "Литера"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_LETTER")]
        IllegalAddressLetter,

        /// <summary>
        /// Недопустимое значение "Дробь"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_SLASH")]
        IllegalAddressSlash,

        /// <summary>
        /// Недопустимое значение "Корпус"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_CORPUS")]
        IllegalAddressCorpus,

        /// <summary>
        /// Недопустимое значение "Строение"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_BUILDING")]
        IllegalAddressBuilding,

        /// <summary>
        /// Недопустимое значение "Комната"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_ROOM")]
        IllegalAddressRoom,

        /// <summary>
        /// Способ оплаты не задан
        /// </summary>
        [EnumMember(Value = "EMPTY_PAYMENT_METHOD")]
        EmptyPaymentMethod,

        /// <summary>
        /// Некорректный способ оплаты
        /// </summary>
        [EnumMember(Value = "ILLEGAL_PAYMENT_METHOD")]
        IllegalPaymentMethod,

        /// <summary>
        /// Доставка по указанному маршруту не осуществляется
        /// </summary>
        [EnumMember(Value = "CODE_1372")]
        Code1372,

        /// <summary>
        /// Ошибка добавления отправления в MMO
        /// </summary>
        [EnumMember(Value = "GROUPING_TO_MMO_ERROR")]
        GroupingToMmoError,

        /// <summary>
        /// Недопустимое значение поля "Имя получателя". (Разрешается использовать только латинские буквы)."
        /// </summary>
        [EnumMember(Value = "ILLEGAL_RECIPIENT_NAME_INTL")]
        IllegalRecipientNameIntl,

        /// <summary>
        /// Не задан адрес (Улица, дом, квартира).
        /// </summary>
        [EnumMember(Value = "EMPTY_STREET_TO")]
        EmptyStreetTo,

        /// <summary>
        /// Не заданы вложения для таможенной декларации.
        /// </summary>
        [EnumMember(Value = "EMPTY_CUSTOMS_ENTRIES")]
        EmptyCustomsEntries,

        /// <summary>
        /// Указание размеров для данного вида РПО не предусмотрено.
        /// </summary>
        [EnumMember(Value = "DIMENSION_NOT_SUPPORTED")]
        DimensionNotSupported,

        /// <summary>
        /// Тип отправления для данного направления не подключен в настройках пользователя.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_MAIL_TYPE")]
        UnavailableMailType,

        /// <summary>
        /// Список товарных вложений пуст.
        /// </summary>
        [EnumMember(Value = "EMPTY_GOODS_ITEMS_LIST")]
        EmptyGoodsItemsList,

        /// <summary>
        /// Не указан Идентификатор пункта выдачи заказов.
        /// </summary>
        [EnumMember(Value = "EMPTY_DELIVERY_POINT_INDEX")]
        EmptyDeliveryPointIndex,

        /// <summary>
        /// Не заполнены фискальные данные.
        /// </summary>
        [EnumMember(Value = "EMPTY_FISCAL_DATA")]
        EmptyFiscalData,

        /// <summary>
        /// Недопустимое значение для "Пакет смс получателю".
        /// </summary>
        [EnumMember(Value = "ILLEGAL_SMS_NOTICE_RECIPIENT_VALUE")]
        IllegalSmsNoticeRecipientValue,

        /// <summary>
        /// Не указан типоразмер.
        /// </summary>
        [EnumMember(Value = "EMPTY_DIMENSION_TYPE")]
        EmptyDimensionType,

        /// <summary>
        /// Некорректный способ оплаты уведомления.
        /// </summary>
        [EnumMember(Value = "ILLEGAL_NOTICE_PAYMENT_METHOD")]
        IllegalNoticePaymentMethod,

        /// <summary>
        /// Группа не найдена.
        /// </summary>
        [EnumMember(Value = "GROUP_NOT_FOUND")]
        GroupNotFound,
    }
}
