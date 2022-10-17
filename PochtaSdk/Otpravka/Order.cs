using System.Runtime.Serialization;
using OksmCountryCode = PochtaSdk.Tariff.OksmCountryCode;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order, base class.
    /// Заказ, базовый класс. Используется при создании заказов.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class Order
    {
        /// <summary>
        /// Отметка 'Добавить в многоместное отправление'
        /// </summary>
        [DataMember(Name = "add-to-mmo")]
        public bool AddToMmo { get; set; }

        /// <summary>
        /// Адрес забора заказа
        /// </summary>
        [DataMember(Name = "address-from")]
        public Address AddressFrom { get; set; }

        /// <summary>
        /// Тип адреса
        /// </summary>
        [DataMember(Name = "address-type-to")]
        public AddressType AddressTypeTo { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        [DataMember(Name = "area-to")]
        public string AreaTo { get; set; }

        /// <summary>
        /// Идентификатор подразделения
        /// </summary>
        [DataMember(Name = "branch-name")]
        public string BranchName { get; set; }

        /// <summary>
        /// Часть здания: Строение
        /// </summary>
        [DataMember(Name = "building-to")]
        public string BuildingTo { get; set; }

        /// <summary>
        /// Комментарий к заказу
        /// </summary>
        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Признак услуги проверки комплектности
        /// </summary>
        [DataMember(Name = "completeness-checking")]
        public bool CompletenessChecking { get; set; }

        /// <summary>
        /// К оплате с получателя (копейки)
        /// </summary>
        [DataMember(Name = "compulsory-payment")]
        public int CompulsoryPayment { get; set; }

        /// <summary>
        /// Часть здания: Корпус
        /// </summary>
        [DataMember(Name = "corpus-to")]
        public string CorpusTo { get; set; }

        /// <summary>
        /// Отметка "Курьер"
        /// </summary>
        [DataMember(Name = "courier")]
        public bool Courier { get; set; }

        /// <summary>
        /// Таможенная декларация (для международных отправлений)
        /// </summary>
        [DataMember(Name = "customs-declaration")]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        /// <summary>
        /// Признак оплаты при получении
        /// </summary>
        [DataMember(Name = "delivery-with-cod")]
        public bool DeliveryWithCod { get; set; }

        /// <summary>
        /// Линейные размеры
        /// </summary>
        [DataMember(Name = "dimension")]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// Типоразмер
        /// </summary>
        [DataMember(Name = "dimension-type")]
        public DimensionType? DimensionType { get; set; }

        /// <summary>
        /// Лёгкий возврат
        /// </summary>
        [DataMember(Name = "easy-return")]
        public bool EasyReturn { get; set; }

        /// <summary>
        /// Данные отправления ЕКОМ
        /// </summary>
        [DataMember(Name = "ecom-data")]
        public EcomData EcomData { get; set; }

        /// <summary>
        /// Тип конверта - ГОСТ Р 51506-99.
        /// </summary>
        [DataMember(Name = "envelope-type")]
        public EnvelopeType? EnvelopeType { get; set; }

        /// <summary>
        /// Фискальные данные
        /// </summary>
        [DataMember(Name = "fiscal-data")]
        public FiscalData FiscalData { get; set; }

        /// <summary>
        /// Установлена ли отметка "Осторожно/Хрупкое"
        /// </summary>
        [DataMember(Name = "fragile")]
        public bool Fragile { get; set; }

        /// <summary>
        /// Имя получателя
        /// </summary>
        [DataMember(Name = "given-name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Товарное вложение РПО
        /// </summary>
        [DataMember(Name = "goods")]
        public OrderGoods Goods { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        [DataMember(Name = "group-name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Название гостиницы
        /// </summary>
        [DataMember(Name = "hotel-to")]
        public string HotelTo { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания
        /// </summary>
        [DataMember(Name = "house-to")]
        public string HouseTo { get; set; }

        /// <summary>
        /// Целое число (Опционально) Почтовый индекс, 
        /// для отправлений адресованных в почтомат или пункт выдачи, 
        /// должен использоваться объект "ecom-data"
        /// </summary>
        [DataMember(Name = "index-to")]
        public int PostCodeTo { get; set; }

        /// <summary>
        /// Дополнительный идентификатор отправления
        /// </summary>
        [DataMember(Name = "inner-num")]
        public string InnerNum { get; set; }

        /// <summary>
        /// Объявленная ценность (копейки)
        /// </summary>
        [DataMember(Name = "insr-value")]
        public int? DeclaredValue { get; set; }

        /// <summary>
        /// Наличие описи вложения
        /// </summary>
        [DataMember(Name = "inventory")]
        public bool Inventory { get; set; }

        /// <summary>
        /// Часть здания: Литера
        /// </summary>
        [DataMember(Name = "letter-to")]
        public string LetterTo { get; set; }

        /// <summary>
        /// Микрорайон
        /// </summary>
        [DataMember(Name = "location-to")]
        public string LocationTo { get; set; }

        /// <summary>
        /// Категория РПО
        /// </summary>
        [DataMember(Name = "mail-category")]
        public MailCategory MailCategory { get; set; }

        /// <summary>
        /// Код страны назначения
        /// </summary>
        [DataMember(Name = "mail-direct")]
        public OksmCountryCode MailCountryCode { get; set; }

        /// <summary>
        /// Вид РПО
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

        /// <summary>
        /// Вес РПО (в граммах)
        /// </summary>
        [DataMember(Name = "mass")]
        public int Mass { get; set; }

        /// <summary>
        /// Отчество получателя
        /// </summary>
        [DataMember(Name = "middle-name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Отметка "Возврату не подлежит"
        /// </summary>
        [DataMember(Name = "no-return")]
        public bool NoReturn { get; set; }

        /// <summary>
        /// Способ оплаты уведомления
        /// </summary>
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod NoticePaymentMethod { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта
        /// </summary>
        [DataMember(Name = "num-address-type-to")]
        public string NumAddressTypeTo { get; set; }

        /// <summary>
        /// Часть здания: Офис
        /// </summary>
        [DataMember(Name = "office-to")]
        public string OfficeTo { get; set; }

        /// <summary>
        /// Номер заказа. Внешний идентификатор заказа, который формируется отправителем
        /// </summary>
        [DataMember(Name = "order-num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// Сумма наложенного платежа (копейки)
        /// </summary>
        [DataMember(Name = "payment")]
        public int Payment { get; set; }

        /// <summary>
        /// Способ оплаты.
        /// </summary>
        [DataMember(Name = "payment-method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        [DataMember(Name = "place-to")]
        public string PlaceTo { get; set; }

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
        public long? TelAddress { get; set; }

        /// <summary>
        /// Телефон отправителя
        /// </summary>
        [DataMember(Name = "tel-address-from")]
        public long? TelAddressFrom { get; set; }

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
        public bool WithoutMailRank { get; set; }
    }
}
