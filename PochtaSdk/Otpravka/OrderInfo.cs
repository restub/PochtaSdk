using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order detailed information.
    /// Заказ, подробная информация. Используется при запросе заказов.
    /// https://otpravka.pochta.ru/specification#/orders-search_order_byid
    /// </summary>
    [DataContract]
    public class OrderInfo : Order
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
        [DataMember(Name = "in-mmo")]
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

        /// <summary>
        /// Коды отметок внутренних и международных отправлений
        /// </summary>
        [DataMember(Name = "postmarks")]
        public PostMark[] PostMarks { get; set; }

        /// <summary>
        /// Надбавка за "Предпочтовая подготовка" с НДС
        /// </summary>
        [DataMember(Name = "pre-postal-preparation-with-vat")]
        public int? PrePostalPreparationWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Предпочтовая подготовка" без НДС
        /// </summary>
        [DataMember(Name = "pre-postal-preparation-wo-vat")]
        public int? PrePostalPreparationWithoutVat { get; set; }
        
        /// <summary>
        /// Область, регион отправителя
        /// </summary>
        [DataMember(Name = "region-from")]
        public string RegionFrom { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения отправителя
        /// </summary>
        [DataMember(Name = "room-from")]
        public string RoomFrom { get; set; }

        /// <summary>
        /// Часть здания: Дробь отправителя
        /// </summary>
        [DataMember(Name = "slash-from")]
        public string SlashFrom { get; set; }

        /// <summary>
        /// Надбавка за "Пакет смс получателю" с НДС
        /// </summary>
        [DataMember(Name = "sms-notice-recipient-rate-with-vat")]
        public int? SmsNoticeRecipientWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Пакет смс получателю" без НДС
        /// </summary>
        [DataMember(Name = "sms-notice-recipient-rate-wo-vat")]
        public int? SmsNoticeRecipientWithoutVat { get; set; }

        /// <summary>
        /// Часть адреса: Улица отправителя
        /// </summary>
        [DataMember(Name = "street-from")]
        public string StreetFrom { get; set; }

        /// <summary>
        /// Плата всего без НДС (коп)
        /// </summary>
        [DataMember(Name = "total-rate-wo-vat")]
        public int TotalRateWithoutVat { get; set; }

        /// <summary>
        /// Всего НДС (коп)
        /// </summary>
        [DataMember(Name = "total-vat")]
        public int TotalVat { get; set; }

        /// <summary>
        /// Версия заказа
        /// </summary>
        [DataMember(Name = "version")]
        public int Version { get; set; }

        /// <summary>
        /// Часть здания: Владение отправителя
        /// </summary>
        [DataMember(Name = "vladenie-from")]
        public string VladenieFrom { get; set; }

        /// <summary>
        /// Надбавка за "Возврат сопроводительных документов" с НДС
        /// </summary>
        [DataMember(Name = "vsd-rate-with-vat")]
        public int? DocumentReturnRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Возврат сопроводительных документов" без НДС
        /// </summary>
        [DataMember(Name = "vsd-rate-wo-vat")]
        public int? DocumentReturnRateWithoutVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений с примеркой" с НДС
        /// </summary>
        [DataMember(Name = "with-fitting-rate-with-vat")]
        public int? WithFittingRateWithVat { get; set; }

        /// <summary>
        /// Надбавка за "Проверку вложений с примеркой" без НДС
        /// </summary>
        [DataMember(Name = "with-fitting-rate-wo-vat")]
        public int? WithFittingRateWithoutVat { get; set; }
    }
}
