using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Все отправления уже отправлены")]
        AllShipmentsSent,

        /// <summary>
        /// Ошибка при получении ШПИ
        /// </summary>
        [EnumMember(Value = "BARCODE_ERROR")]
        [Display(Name = "Ошибка при получении ШПИ")]
        BarcodeError,

        /// <summary>
        /// Тип адреса не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_ADDRESS_TYPE_TO")]
        [Display(Name = "Тип адреса не указан")]
        EmptyAddressTypeTo,

        /// <summary>
        /// Почтовый индекс не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_INDEX_TO")]
        [Display(Name = "Почтовый индекс не указан")]
        EmptyPostCodeTo,

        /// <summary>
        /// Объявленная сумма не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_INSR_VALUE")]
        [Display(Name = "Объявленная сумма не указана")]
        EmptyDeclaredValue,

        /// <summary>
        /// Категория почтового отправления не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_CATEGORY")]
        [Display(Name = "Категория почтового отправления не указана")]
        EmptyMailCategory,

        /// <summary>
        /// Почтовое направление не указано
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_DIRECT")]
        [Display(Name = "Почтовое направление не указано")]
        EmptyMailDirect,

        /// <summary>
        /// Тип почтового отправления не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_TYPE")]
        [Display(Name = "Тип почтового отправления не указан")]
        EmptyMailType,

        /// <summary>
        /// Масса не указана
        /// </summary>
        [EnumMember(Value = "EMPTY_MASS")]
        [Display(Name = "Масса не указана")]
        EmptyMass,

        /// <summary>
        /// Не задан номер для соответствующего типа адреса
        /// </summary>
        [EnumMember(Value = "EMPTY_NUM_ADDRESS_TYPE")]
        [Display(Name = "Не задан номер для соответствующего типа адреса")]
        EmptyNumAddressType,

        /// <summary>
        /// Наложенный платеж не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_PAYMENT")]
        [Display(Name = "Наложенный платеж не указан")]
        EmptyPayment,

        /// <summary>
        /// Населенный пункт не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_PLACE_TO")]
        [Display(Name = "Населенный пункт не указан")]
        EmptyPlaceTo,

        /// <summary>
        /// Регион не заполнен
        /// </summary>
        [EnumMember(Value = "EMPTY_REGION_TO")]
        [Display(Name = "Регион не заполнен")]
        EmptyRegionTo,

        /// <summary>
        /// Способ пересылки не указан
        /// </summary>
        [EnumMember(Value = "EMPTY_TRANSPORT_TYPE")]
        [Display(Name = "Способ пересылки не указан")]
        EmptyTransportType,

        /// <summary>
        /// Индекс приемного почтового отделения не задан
        /// </summary>
        [EnumMember(Value = "EMPTY_POSTOFFICE_CODE")]
        [Display(Name = "Индекс приемного почтового отделения не задан")]
        EmptyPostOfficeCode,

        /// <summary>
        /// Тип адреса некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_TYPE_TO")]
        [Display(Name = "Тип адреса некорректен")]
        IllegalAddressTypeTo,

        /// <summary>
        /// Почтовый индекс некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INDEX_TO")]
        [Display(Name = "Почтовый индекс некорректен")]
        IllegalPostCodeTo,

        /// <summary>
        /// ФИО некорректно
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INITIALS")]
        [Display(Name = "ФИО некорректно")]
        IllegalInitials,

        /// <summary>
        /// Объявленная сумма некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_INSR_VALUE")]
        [Display(Name = "Объявленная сумма некорректна")]
        IllegalDeclaredValue,

        /// <summary>
        /// Категория почтового отправления некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_CATEGORY")]
        [Display(Name = "Категория почтового отправления некорректна")]
        IllegalMailCategory,

        /// <summary>
        /// Почтовое направление некорректно
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_DIRECT")]
        [Display(Name = "Почтовое направление некорректно")]
        IllegalMailDirect,

        /// <summary>
        /// Тип почтового отправления некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MAIL_TYPE")]
        [Display(Name = "Тип почтового отправления некорректен")]
        IllegalMailType,

        /// <summary>
        /// Масса некорректна
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MASS")]
        [Display(Name = "Масса некорректна")]
        IllegalMass,

        /// <summary>
        /// Вес отправления не должен превышать N кг
        /// </summary>
        [EnumMember(Value = "ILLEGAL_MASS_EXCESS")]
        [Display(Name = "Вес отправления не должен превышать N кг")]
        IllegalMassExcess,

        /// <summary>
        /// Наложенный платеж некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_PAYMENT")]
        [Display(Name = "Наложенный платеж некорректен")]
        IllegalPayment,

        /// <summary>
        /// Индекс приемного почтового отделения в настройках и в партии отличаются
        /// </summary>
        [EnumMember(Value = "ILLEGAL_POSTCODE")]
        [Display(Name = "Индекс приемного почтового отделения в настройках и в партии отличаются")]
        IllegalPostCode,

        /// <summary>
        /// Индекс приемного почтового отделения некорректен
        /// </summary>
        [EnumMember(Value = "ILLEGAL_POSTOFFICE_CODE")]
        [Display(Name = "Индекс приемного почтового отделения некорректен")]
        IllegalPostOfficeCode,

        /// <summary>
        /// Некорректный способ пересылки
        /// </summary>
        [EnumMember(Value = "ILLEGAL_TRANSPORT_TYPE")]
        [Display(Name = "Некорректный способ пересылки")]
        IllegalTransportType,

        /// <summary>
        /// Ошибка имперсонализации
        /// </summary>
        [EnumMember(Value = "IMP13N_ERROR")]
        [Display(Name = "Ошибка имперсонализации")]
        Imp13nError,

        /// <summary>
        /// Превышено максимальное значение N руб
        /// </summary>
        [EnumMember(Value = "INSR_VALUE_EXCEEDS_MAX")]
        [Display(Name = "Превышено максимальное значение N руб")]
        DeclaredValueExceedsMax,

        /// <summary>
        /// Нет доступных точек сдачи или отделений места приема
        /// </summary>
        [EnumMember(Value = "NO_AVAILABLE_POSTOFFICES")]
        [Display(Name = "Нет доступных точек сдачи или отделений места приема")]
        NoAvailablePostOffices,

        /// <summary>
        /// Не найден
        /// </summary>
        [EnumMember(Value = "NOT_FOUND")]
        [Display(Name = "Не найден")]
        NotFound,

        /// <summary>
        /// Дата отправки просрочена
        /// </summary>
        [EnumMember(Value = "PAST_DUE_DATE")]
        [Display(Name = "Дата отправки просрочена")]
        PastDueDate,

        /// <summary>
        /// Изменения в партии недопустимы
        /// </summary>
        [EnumMember(Value = "READONLY_STATE")]
        [Display(Name = "Изменения в партии недопустимы")]
        ReadonlyState,

        /// <summary>
        /// Для создания отправлений с наложенным платежом необходимо указать номер ЕСПП в настройках сервиса. Обратитесь к вашему персональному менеджеру в Почте или напишите письмо на почтовый ящик support.otpravka@russianpost.ru
        /// </summary>
        [EnumMember(Value = "RESTRICTED_MAIL_CATEGORY")]
        [Display(Name = "Для создания отправлений с наложенным платежом необходимо указать номер ЕСПП в настройках сервиса. Обратитесь к вашему персональному менеджеру в Почте или напишите письмо на почтовый ящик support.otpravka@russianpost.ru")]
        RestrictedMailCategory,

        /// <summary>
        /// Ошибка при отправке почты
        /// </summary>
        [EnumMember(Value = "SENDING_MAIL_FAILED")]
        [Display(Name = "Ошибка при отправке почты")]
        SendingMailFailed,

        /// <summary>
        /// Ошибка при расчете тарифа
        /// </summary>
        [EnumMember(Value = "TARIFF_ERROR")]
        [Display(Name = "Ошибка при расчете тарифа")]
        TariffError,

        /// <summary>
        /// Способы пересылки отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_TRANSPORT_TYPE")]
        [Display(Name = "Способы пересылки отправления и партии отличаются")]
        DifferentTransportType,

        /// <summary>
        /// Типы почтовых отправлений не совпадают
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_TYPE")]
        [Display(Name = "Типы почтовых отправлений не совпадают")]
        DifferentMailType,

        /// <summary>
        /// Категории почтовых отправления не совпадают
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_CATEGORY")]
        [Display(Name = "Категории почтовых отправления не совпадают")]
        DifferentMailCategory,

        /// <summary>
        /// Разряд отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_MAIL_RANK")]
        [Display(Name = "Разряд отправления и партии отличаются")]
        DifferentMailRank,

        /// <summary>
        /// Отправление не может быть добавлено в партию с отметкой "Негабаритная"
        /// </summary>
        [EnumMember(Value = "ABSENT_OVERSIZE_POSTMARK")]
        [Display(Name = "Отправление не может быть добавлено в партию с отметкой Негабаритная")]
        AbsentOversizePostMark,

        /// <summary>
        /// Негабаритное отправление не может быть добавлено в партию без отметки "Негабаритная"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_OVERSIZE_POSTMARK")]
        [Display(Name = "Негабаритное отправление не может быть добавлено в партию без отметки Негабаритная")]
        UnexpectedOversizePostMark,

        /// <summary>
        /// Отправление без отметки "Осторожно/Хрупкое" не может быть добавлено в партию с отметкой "Осторожно/Хрупкое"
        /// </summary>
        [EnumMember(Value = "ABSENT_FRAGILE_POSTMARK")]
        [Display(Name = "Отправление без отметки Осторожно/Хрупкое не может быть добавлено в партию с отметкой Осторожно/Хрупкое")]
        AbsentFragilePostMark,

        /// <summary>
        /// Отправление с отметкой "Осторожно/Хрупкое" не может быть добавлено в партию без отметки "Осторожно/Хрупкое"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_FRAGILE_POSTMARK")]
        [Display(Name = "Отправление с отметкой Осторожно/Хрупкое не может быть добавлено в партию без отметки Осторожно/Хрупкое")]
        UnexpectedFragilePostMark,

        /// <summary>
        /// Отправление без отметки "Курьер" не может быть добавлено в партию с отметкой "Курьер"
        /// </summary>
        [EnumMember(Value = "ABSENT_COURIER_DELIVERY_POSTMARK")]
        [Display(Name = "Отправление без отметки Курьер не может быть добавлено в партию с отметкой Курьер")]
        AbsentCourierDeliveryPostMark,

        /// <summary>
        /// Отправление с отметкой "Курьер" не может быть добавлено в партию без отметки "Курьер"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_COURIER_DELIVERY_POSTMARK")]
        [Display(Name = "Отправление с отметкой Курьер не может быть добавлено в партию без отметки Курьер")]
        UnexpectedCourierDeliveryPostMark,

        /// <summary>
        /// Отправление без отметки "С заказным уведомлением" не может быть добавлено в партию с отметкой "С заказным уведомлением"
        /// </summary>
        [EnumMember(Value = "ABSENT_ORDER_OF_NOTICE_POSTMARK")]
        [Display(Name = "Отправление без отметки С заказным уведомлением не может быть добавлено в партию с отметкой С заказным уведомлением")]
        AbsentOrderOfNoticePostMark,

        /// <summary>
        /// Отправление с отметкой "С заказным уведомлением" не может быть добавлено в партию без отметки "С заказным уведомлением"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_ORDER_OF_NOTICE_POSTMARK")]
        [Display(Name = "Отправление с отметкой С заказным уведомлением не может быть добавлено в партию без отметки С заказным уведомлением")]
        UnexpectedOrderOfNoticePostMark,

        /// <summary>
        /// Отправление без отметки "С простым уведомлением" не может быть добавлено в партию с отметкой "С простым уведомлением"
        /// </summary>
        [EnumMember(Value = "ABSENT_SIMPLE_NOTICE_POSTMARK")]
        [Display(Name = "Отправление без отметки С простым уведомлением не может быть добавлено в партию с отметкой С простым уведомлением")]
        AbsentSimpleNoticePostMark,

        /// <summary>
        /// Отправление с отметкой "С простым уведомлением" не может быть добавлено в партию без отметки "С простым уведомлением"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_SIMPLE_NOTICE_POSTMARK")]
        [Display(Name = "Отправление с отметкой С простым уведомлением не может быть добавлено в партию без отметки С простым уведомлением")]
        UnexpectedSimpleNoticePostMark,

        /// <summary>
        /// Неопределенная ошибка
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        [Display(Name = "Неопределенная ошибка")]
        Undefined,

        /// <summary>
        /// Нарушение доступа
        /// </summary>
        [EnumMember(Value = "ACCESS_VIOLATION")]
        [Display(Name = "Нарушение доступа")]
        AccessViolation,

        /// <summary>
        /// Отправление уже отправлено
        /// </summary>
        [EnumMember(Value = "DELIVERY_IN_PROGRESS")]
        [Display(Name = "Отправление уже отправлено")]
        DeliveryInProgress,

        /// <summary>
        /// Телефон получателя является обязательным для данного вида отправления
        /// </summary>
        [EnumMember(Value = "EMPTY_TELADDRESS")]
        [Display(Name = "Телефон получателя является обязательным для данного вида отправления")]
        EmptyTelAddress,

        /// <summary>
        /// Наложенный платеж превышает объявленную ценность
        /// </summary>
        [EnumMember(Value = "NOT_INSURED_PAYMENT")]
        [Display(Name = "Наложенный платеж превышает объявленную ценность")]
        NotInsuredPayment,

        /// <summary>
        /// Способы пересылки отправления и партии отличаются
        /// </summary>
        [EnumMember(Value = "DIFFERENT_POSTCODE")]
        [Display(Name = "Способы пересылки отправления и партии отличаются")]
        DifferentPostCode,

        /// <summary>
        /// Отметка "Осторожно/Хрупкое" неприменима для указанного типа отправлений
        /// </summary>
        [EnumMember(Value = "ILLEGAL_FRAGILE")]
        [Display(Name = "Отметка Осторожно/Хрупкое неприменима для указанного типа отправлений")]
        IllegalFragile,

        /// <summary>
        /// Код разряда почтового отправления не задан в настройках пользователя
        /// </summary>
        [EnumMember(Value = "EMPTY_MAIL_RANK")]
        [Display(Name = "Код разряда почтового отправления не задан в настройках пользователя")]
        EmptyMailRank,

        /// <summary>
        /// Не задан тип конверта
        /// </summary>
        [EnumMember(Value = "EMPTY_ENVELOPE_TYPE")]
        [Display(Name = "Не задан тип конверта")]
        EmptyEnvelopeType,

        /// <summary>
        /// Недопустимое значение "Тип конверта" для выбранного вида отправления
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ENVELOPE_TYPE")]
        [Display(Name = "Недопустимое значение Тип конверта для выбранного вида отправления")]
        IllegalEnvelopeType,

        /// <summary>
        /// Недопустимое значение "Литера"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_LETTER")]
        [Display(Name = "Недопустимое значение Литера")]
        IllegalAddressLetter,

        /// <summary>
        /// Недопустимое значение "Дробь"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_SLASH")]
        [Display(Name = "Недопустимое значение Дробь")]
        IllegalAddressSlash,

        /// <summary>
        /// Недопустимое значение "Корпус"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_CORPUS")]
        [Display(Name = "Недопустимое значение Корпус")]
        IllegalAddressCorpus,

        /// <summary>
        /// Недопустимое значение "Строение"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_BUILDING")]
        [Display(Name = "Недопустимое значение Строение")]
        IllegalAddressBuilding,

        /// <summary>
        /// Недопустимое значение "Комната"
        /// </summary>
        [EnumMember(Value = "ILLEGAL_ADDRESS_ROOM")]
        [Display(Name = "Недопустимое значение Комната")]
        IllegalAddressRoom,

        /// <summary>
        /// Способ оплаты не задан
        /// </summary>
        [EnumMember(Value = "EMPTY_PAYMENT_METHOD")]
        [Display(Name = "Способ оплаты не задан")]
        EmptyPaymentMethod,

        /// <summary>
        /// Некорректный способ оплаты
        /// </summary>
        [EnumMember(Value = "ILLEGAL_PAYMENT_METHOD")]
        [Display(Name = "Некорректный способ оплаты")]
        IllegalPaymentMethod,

        /// <summary>
        /// Доставка по указанному маршруту не осуществляется
        /// </summary>
        [EnumMember(Value = "CODE_1372")]
        [Display(Name = "Доставка по указанному маршруту не осуществляется")]
        Code1372,

        /// <summary>
        /// Ошибка добавления отправления в MMO
        /// </summary>
        [EnumMember(Value = "GROUPING_TO_MMO_ERROR")]
        [Display(Name = "Ошибка добавления отправления в MMO")]
        GroupingToMmoError,

        /// <summary>
        /// Недопустимое значение поля "Имя получателя". (Разрешается использовать только латинские буквы)."
        /// </summary>
        [EnumMember(Value = "ILLEGAL_RECIPIENT_NAME_INTL")]
        [Display(Name = "Недопустимое значение поля Имя получателя (Разрешается использовать только латинские буквы).")]
        IllegalRecipientNameIntl,

        /// <summary>
        /// Не задан адрес (Улица, дом, квартира).
        /// </summary>
        [EnumMember(Value = "EMPTY_STREET_TO")]
        [Display(Name = "Не задан адрес (Улица, дом, квартира)")]
        EmptyStreetTo,

        /// <summary>
        /// Не заданы вложения для таможенной декларации.
        /// </summary>
        [EnumMember(Value = "EMPTY_CUSTOMS_ENTRIES")]
        [Display(Name = "Не заданы вложения для таможенной декларации")]
        EmptyCustomsEntries,

        /// <summary>
        /// Указание размеров для данного вида РПО не предусмотрено.
        /// </summary>
        [EnumMember(Value = "DIMENSION_NOT_SUPPORTED")]
        [Display(Name = "Указание размеров для данного вида РПО не предусмотрено")]
        DimensionNotSupported,

        /// <summary>
        /// Тип отправления для данного направления не подключен в настройках пользователя.
        /// </summary>
        [EnumMember(Value = "UNAVAILABLE_MAIL_TYPE")]
        [Display(Name = "Тип отправления для данного направления не подключен в настройках пользователя")]
        UnavailableMailType,

        /// <summary>
        /// Список товарных вложений пуст.
        /// </summary>
        [EnumMember(Value = "EMPTY_GOODS_ITEMS_LIST")]
        [Display(Name = "Список товарных вложений пуст")]
        EmptyGoodsItemsList,

        /// <summary>
        /// Не указан Идентификатор пункта выдачи заказов.
        /// </summary>
        [EnumMember(Value = "EMPTY_DELIVERY_POINT_INDEX")]
        [Display(Name = "Не указан Идентификатор пункта выдачи заказов")]
        EmptyDeliveryPointPostCode,

        /// <summary>
        /// Не заполнены фискальные данные.
        /// </summary>
        [EnumMember(Value = "EMPTY_FISCAL_DATA")]
        [Display(Name = "Не заполнены фискальные данные")]
        EmptyFiscalData,

        /// <summary>
        /// Недопустимое значение для "Пакет смс получателю".
        /// </summary>
        [EnumMember(Value = "ILLEGAL_SMS_NOTICE_RECIPIENT_VALUE")]
        [Display(Name = "Недопустимое значение для Пакет смс получателю")]
        IllegalSmsNoticeRecipientValue,

        /// <summary>
        /// Не указан типоразмер.
        /// </summary>
        [EnumMember(Value = "EMPTY_DIMENSION_TYPE")]
        [Display(Name = "Не указан типоразмер")]
        EmptyDimensionType,

        /// <summary>
        /// Некорректный способ оплаты уведомления.
        /// </summary>
        [EnumMember(Value = "ILLEGAL_NOTICE_PAYMENT_METHOD")]
        [Display(Name = "Некорректный способ оплаты уведомления")]
        IllegalNoticePaymentMethod,

        /// <summary>
        /// Группа не найдена.
        /// </summary>
        [EnumMember(Value = "GROUP_NOT_FOUND")]
        [Display(Name = "Группа не найдена")]
        GroupNotFound,
    }
}
