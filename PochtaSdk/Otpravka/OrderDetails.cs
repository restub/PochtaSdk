using System.Runtime.Serialization;
using OksmCountryCode = PochtaSdk.Tariff.OksmCountryCode;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order details.
    /// Заказ, подробности. Используется при запросе заказов.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class OrderDetails : Order
    {
        /// <summary>
        /// Адрес получателя скорректирован в процессе очистки
        /// </summary>
        [DataMember(Name = "address-changed")]
        public bool AddressChanged { get; set; }

        /// <summary>
        /// Тип адреса отправления
        /// </summary>
        [DataMember(Name = "address-type-from")]
        public AddressType AddressTypeFrom { get; set; }

        /// <summary>
        /// Район отправления
        /// </summary>
        [DataMember(Name = "area-from")]
        public string AreaFrom { get; set; }

        /// <summary>
        /// Авиа-сбор без НДС (для совместимости)
        /// </summary>
        [DataMember(Name = "avia-rate")]
        public int? AviaRate { get; set; }

        /// <summary>
        /// Авиа-сбор с НДС
        /// </summary>
        [DataMember(Name = "avia-rate-with-vat")]
        public int? AviaRateWithVat { get; set; }

        /// <summary>
        /// Авиа-сбор без НДС
        /// </summary>
        [DataMember(Name = "avia-rate-wo-vat")]
        public int? AviaRateWithoutVat { get; set; }

        /// <summary>
        /// ШПИ (штриховой почтовый идентификатор внутреннего регистрируемого почтового отправления)
        /// </summary>
        [DataMember(Name = "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Хэш-код
        /// </summary>
        [DataMember(Name = "bk-hash")]
        public string BkHash { get; set; }

        /// <summary>
        /// Часть здания: Строение отправителя
        /// </summary>
        [DataMember(Name = "building-from")]
        public string BuildingFrom { get; set; }

        /// <summary>
        /// Надбавка за "Проверку комплектности" с НДС
        /// </summary>
        [DataMember(Name = "completeness-checking-rate-with-vat")]
        public int? CompletenessCheckingRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку комплектности" без НДС
        /// </summary>
        [DataMember(Name = "completeness-checking-rate-wo-vat")]
        public int? CompletenessCheckingRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений" с НДС
        /// </summary>
        [DataMember(Name = "contents-checking-rate-with-vat")]
        public int? ContentsCheckingRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений" без НДС
        /// </summary>
        [DataMember(Name = "contents-checking-rate-wo-vat")]
        public int? ContentsCheckingRateWithoutVat { get; set; }

        /// <summary>
        /// Часть здания: Корпус отправителя
        /// </summary>
        [DataMember(Name = "corpus-from")]
        public string CorpusFrom { get; set; }

        /// <summary>
        /// Результат электронного декларирования
        /// </summary>
        [DataMember(Name = "declaration-status")]
        public CustomsDeclarationStatus? DeclarationStatus { get; set; }

        /// <summary>
        /// Примерные сроки доставки
        /// </summary>
        [DataMember(Name = "delivery-time")]
        public DeliveryTerms DeliveryTime { get; set; }

        /// <summary>
        /// Сбор за "Лёгкий возврат" с НДС
        /// </summary>
        [DataMember(Name = "easy-return-rate-with-vat")]
        public int? EasyReturnRateWithVat { get; set; }

        /// <summary>
        /// Сбор за "Лёгкий возврат" без НДС
        /// </summary>
        [DataMember(Name = "easy-return-rate-wo-vat")]
        public int? EasyReturnRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за отметку "Осторожно/Хрупкое" с НДС
        /// </summary>
        [DataMember(Name = "fragile-rate-with-vat")]
        public int? FragileRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за отметку "Осторожно/Хрупкое" без НДС
        /// </summary>
        [DataMember(Name = "fragile-rate-wo-vat")]
        public int? FragileRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений с проверкой работоспособности" с НДС
        /// </summary>
        [DataMember(Name = "functionality-checking-rate-with-vat")]
        public int? FunctionalityCheckingRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений с проверкой работоспособности" без НДС
        /// </summary>
        [DataMember(Name = "functionality-checking-rate-wo-vat")]
        public int? FunctionalityCheckingRateWithoutVat { get; set; }

        /// <summary>
        /// Сбор за доставку наземно без НДС (для совместимости)
        /// </summary>
        [DataMember(Name = "ground-rate")]
        public int? GroundRate { get; set; }

        /// <summary>
        /// Сбор за доставку наземно с НДС
        /// </summary>
        [DataMember(Name = "ground-rate-with-vat")]
        public int? GroundRateWithVat { get; set; }

        /// <summary>
        /// Сбор за доставку наземно без НДС
        /// </summary>
        [DataMember(Name = "ground-rate-wo-vat")]
        public int? GroundRateWithoutVat { get; set; }

        /// <summary>
        /// Название гостиницы отправителя
        /// </summary>
        [DataMember(Name = "hotel-from")]
        public string HotelFrom { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания отправителя
        /// </summary>
        [DataMember(Name = "house-from")]
        public string HouseFrom { get; set; }

        /// <summary>
        /// Код заказа?
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Отправление в составе ММО (многоместного отправления)
        /// </summary>
        [DataMember(Name = "id")]
        public bool InMmo { get; set; }

        /// <summary>
        /// Почтовый индекс отправителя
        /// </summary>
        [DataMember(Name = "index-from")]
        public int PostCodeFrom { get; set; }

        /// <summary>
        /// Плата за ОЦ без НДС (для совместимости)
        /// </summary>
        [DataMember(Name = "insr-rate")]
        public int? DeclaredValueRate { get; set; }

        /// <summary>
        /// Плата за ОЦ с НДС
        /// </summary>
        [DataMember(Name = "insr-rate-with-vat")]
        public int? DeclaredValueRateWithVat { get; set; }

        /// <summary>
        /// Плата за ОЦ без НДС
        /// </summary>
        [DataMember(Name = "insr-rate-wo-vat")]
        public int? DeclaredValueRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за "Опись вложения" с НДС
        /// </summary>
        [DataMember(Name = "inventory-rate-with-vat")]
        public int? InventoryRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Опись вложения" без НДС
        /// </summary>
        [DataMember(Name = "inventory-rate-wo-vat")]
        public int? InventoryRateWithoutVat { get; set; }

        /// <summary>
        /// Заказ удален?
        /// </summary>
        [DataMember(Name = "is-deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Часть здания: Литера отправителя
        /// </summary>
        [DataMember(Name = "letter-From")]
        public string LetterFrom { get; set; }

        /// <summary>
        /// ШПИ связанного отправления
        /// </summary>
        [DataMember(Name = "linked-barcode")]
        public string LinkedBarcode { get; set; }

        /// <summary>
        /// Микрорайон отправителя
        /// </summary>
        [DataMember(Name = "location-from")]
        public string LocationFrom { get; set; }

        /// <summary>
        /// Разряд письма
        /// </summary>
        [DataMember(Name = "mail-rank")]
        public MailRank MailRank { get; set; }

        /// <summary>
        /// Почтовый сбор без НДС (для совместимости)
        /// </summary>
        [DataMember(Name = "mass-rate")]
        public int? MassRate { get; set; }

        /// <summary>
        /// Почтовый сбор с НДС
        /// </summary>
        [DataMember(Name = "mass-rate-with-vat")]
        public int? MassRateWithVat { get; set; }

        /// <summary>
        /// Почтовый сбор без НДС
        /// </summary>
        [DataMember(Name = "mass-rate-wo-vat")]
        public int? MassRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за уведомление о вручении с НДС
        /// </summary>
        [DataMember(Name = "notice-rate-with-vat")]
        public int? NoticeRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за уведомление о вручении без НДС
        /// </summary>
        [DataMember(Name = "notice-rate-wo-vat")]
        public int? NoticeRateWithoutVat { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта отправителя
        /// </summary>
        [DataMember(Name = "num-address-type-from")]
        public string NumAddressTypeFrom { get; set; }

        /// <summary>
        /// Часть здания: Офис отправителя
        /// </summary>
        [DataMember(Name = "office-from")]
        public string OfficeFrom { get; set; }

        /// <summary>
        /// Надбавка за негабарит при весе более 10кг с НДС
        /// </summary>
        [DataMember(Name = "oversize-rate-with-vat")]
        public int? OversizeRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за негабарит при весе более 10кг без НДС
        /// </summary>
        [DataMember(Name = "oversize-rate-wo-vat")]
        public int? OversizeRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за "Частичный выкуп" с НДС
        /// </summary>
        [DataMember(Name = "partial-redemption-rate-with-vat")]
        public int? PartialRedemptionRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Частичный выкуп" без НДС
        /// </summary>
        [DataMember(Name = "partial-redemption-rate-wo-vat")]
        public int? PartialRedemptionRateWithoutVat { get; set; }

        /// <summary>
        /// Населенный пункт отправителя
        /// </summary>
        [DataMember(Name = "place-from")]
        public string PlaceFrom { get; set; }

        /*/----

        /// <summary>
        /// Индекс места приема
        /// </summary>
        [DataMember(Name = "postoffice-code")]
        public string PostOfficeCode { get; set; }

        /// <summary>
        /// Предпочтовая подготовка
        /// </summary>
        [DataMember(Name = "pre-postal-preparation")]
        public bool PrePostalPreparation { get; set; }

        /// <summary>
        /// Сумма частичной предоплаты
        /// </summary>
        [DataMember(Name = "prepaid-amount")]
        public int PrepaidAmount { get; set; }

        /// <summary>
        /// Необработанный адрес получателя
        /// </summary>
        [DataMember(Name = "raw-address")]
        public string RawAddress { get; set; }

        /// <summary>
        /// Наименование получателя одной строкой (ФИО, наименование организации)
        /// </summary>
        [DataMember(Name = "recipient-name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// Область, регион
        /// </summary>
        [DataMember(Name = "region-to")]
        public string RegionTo { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения
        /// </summary>
        [DataMember(Name = "room-to")]
        public string RoomTo { get; set; }

        /// <summary>
        /// Комментарий отправителя для ЭУВ
        /// </summary>
        [DataMember(Name = "sender-comment")]
        public string SenderComment{ get; set; }

        /// <summary>
        /// Наименование отправителя одной строкой (ФИО, наименование организации)
        /// </summary>
        [DataMember(Name = "sender-name")]
        public string SenderName { get; set; }

        /// <summary>
        /// Срок хранения отправления от 15 до 60 дней
        /// </summary>
        [DataMember(Name = "shelf-life-days")]
        public int? ShelfLifeDays { get; set; }

        /// <summary>
        /// Часть здания: Дробь
        /// </summary>
        [DataMember(Name = "slash-to")]
        public string SlashTo { get; set; }

        /// <summary>
        /// Признак услуги SMS уведомления
        /// </summary>
        [DataMember(Name = "sms-notice-recipient")]
        public int SmsNoticeRecipient { get; set; }

        /// <summary>
        /// Почтовый индекс (буквенно-цифровой)
        /// </summary>
        [DataMember(Name = "str-index-to")]
        public string PostalCodeTo { get; set; }

        /// <summary>
        /// Часть адреса: Улица
        /// </summary>
        [DataMember(Name = "street-to")]
        public string StreetTo { get; set; }

        /// <summary>
        /// Фамилия получателя
        /// </summary>
        [DataMember(Name = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Телефон получателя (может быть обязательным для некоторых типов отправлений)
        /// </summary>
        [DataMember(Name = "tel-address")]
        public long TelAddress { get; set; }

        /// <summary>
        /// Телефон отправителя
        /// </summary>
        [DataMember(Name = "tel-address-from")]
        public long TelAddressFrom { get; set; }

        /// <summary>
        /// Идентификатор временного интервала
        /// </summary>
        [DataMember(Name = "time-slot-id")]
        public int? TimeSlotID { get; set; }

        /// <summary>
        /// Возможный вид транспортировки (для международных отправлений).
        /// </summary>
        [DataMember(Name = "transport-type")]
        public TransportType? TransportType { get; set; }

        /// <summary>
        /// Часть здания: Владение
        /// </summary>
        [DataMember(Name = "vladenie-to")]
        public string VladenieTo { get; set; }

        /// <summary>
        /// Возврат сопроводительных документов
        /// </summary>
        [DataMember(Name = "vsd")]
        public bool DocumentReturn { get; set; }

        /// <summary>
        /// С документами (для ЕМС международного)
        /// </summary>
        [DataMember(Name = "with-documents")]
        public bool WithDocuments { get; set; }

        /// <summary>
        /// Отметка 'С электронным уведомлением'
        /// </summary>
        [DataMember(Name = "with-electronic-notice")]
        public bool WithElectronicNotice { get; set; }

        /// <summary>
        /// С товарами (для ЕМС международного)
        /// </summary>
        [DataMember(Name = "with-goods")]
        public bool WithGoods { get; set; }

        /// <summary>
        /// Отметка 'С заказным уведомлением'
        /// </summary>
        [DataMember(Name = "with-order-of-notice")]
        public bool WithOrderOfNotice { get; set; }

        /// <summary>
        /// Отметка 'С простым уведомлением'
        /// </summary>
        [DataMember(Name = "with-simple-notice")]
        public bool WithSimpleNotice { get; set; }

        /// <summary>
        /// Отметка "Без разряда"
        /// </summary>
        [DataMember(Name = "wo-mail-rank")]
        public bool WithoutMailRank { get; set; }*/
    }
}
