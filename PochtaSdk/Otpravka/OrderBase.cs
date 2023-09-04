using System.Runtime.Serialization;
using Newtonsoft.Json;
using Restub.Toolbox;
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
    public class OrderBase
    {
        /// <summary>
        /// Отметка 'Добавить в многоместное отправление'.
        /// </summary>
        /// <remarks>
        /// Поддержка многоместных отправлений должна быть включена в профиле клиента.
        /// Кроме того, не все виды РПО поддерживают многоместные отправления.
        /// Известно, что поддерживается в Посылке Онлайн, Курьер Онлайн.
        /// </remarks>
        [DataMember(Name = "add-to-mmo")]
        public bool? AddToMmo { get; set; }

        /// <summary>
        /// Адрес забора заказа
        /// </summary>
        [DataMember(Name = "address-from")]
        public Address AddressFrom { get; set; }

        /// <summary>
        /// Идентификатор подразделения
        /// </summary>
        [DataMember(Name = "branch-name")]
        public string BranchName { get; set; }

        /// <summary>
        /// Комментарий к заказу
        /// </summary>
        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Признак услуги проверки комплектности
        /// </summary>
        [DataMember(Name = "completeness-checking")]
        public bool? CompletenessChecking { get; set; }

        /// <summary>
        /// К оплате с получателя (копейки)
        /// </summary>
        [DataMember(Name = "compulsory-payment")]
        public int? CompulsoryPayment { get; set; }

        /// <summary>
        /// Отметка "Курьер"
        /// </summary>
        [DataMember(Name = "courier")]
        public bool? Courier { get; set; }

        /// <summary>
        /// Таможенная декларация (для международных отправлений)
        /// </summary>
        [DataMember(Name = "customs-declaration")]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        /// <summary>
        /// Признак оплаты при получении
        /// </summary>
        [DataMember(Name = "delivery-with-cod")]
        public bool? DeliveryWithCod { get; set; }

        /// <summary>
        /// Линейные размеры
        /// </summary>
        /// <remarks>
        /// Поддерживаются не для всех видов РПО.
        /// Например, нельзя указывать размеры для Посылки Онлайн и Посылки 1 класса.
        /// </remarks>
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
        public bool? EasyReturn { get; set; }

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
        public bool? Fragile { get; set; }

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
        public bool? Inventory { get; set; }

        /// <summary>
        /// Категория РПО
        /// </summary>
        [DataMember(Name = "mail-category")]
        public MailCategory MailCategory { get; set; }

        /// <summary>
        /// Код страны назначения
        /// </summary>
        [DataMember(Name = "mail-direct")]
        public OksmCountryCode MailCountryCode { get; set; } = OksmCountryCode.Russia;

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
        public bool? NoReturn { get; set; }

        /// <summary>
        /// Способ оплаты уведомления
        /// </summary>
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod? NoticePaymentMethod { get; set; }

        /// <summary>
        /// Номер заказа. Внешний идентификатор заказа, который формируется отправителем
        /// </summary>
        [DataMember(Name = "order-num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// Сумма наложенного платежа (копейки)
        /// </summary>
        [DataMember(Name = "payment")]
        public int? Payment { get; set; }

        /// <summary>
        /// Способ оплаты.
        /// </summary>
        [DataMember(Name = "payment-method")]
        public PaymentMethod? PaymentMethod { get; set; }

        /// <summary>
        /// Индекс места приема
        /// </summary>
        [DataMember(Name = "postoffice-code")]
        public string PostOfficeCode { get; set; }

        /// <summary>
        /// Предпочтовая подготовка
        /// </summary>
        [DataMember(Name = "pre-postal-preparation")]
        public bool? PrePostalPreparation { get; set; }

        /// <summary>
        /// Сумма частичной предоплаты
        /// </summary>
        [DataMember(Name = "prepaid-amount")]
        public int? PrepaidAmount { get; set; }

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
        /// Признак услуги SMS уведомления
        /// </summary>
        /// <remarks>
        /// Сериализуется как 1 или 0
        /// </remarks>
        [DataMember(Name = "sms-notice-recipient"), JsonConverter(typeof(BoolIntConverter))]
        public bool? SmsNoticeRecipient;

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
        /// Возврат сопроводительных документов
        /// </summary>
        [DataMember(Name = "vsd")]
        public bool? DocumentReturn { get; set; }

        /// <summary>
        /// С документами (для ЕМС международного)
        /// </summary>
        [DataMember(Name = "with-documents")]
        public bool? WithDocuments { get; set; }

        /// <summary>
        /// Отметка 'С электронным уведомлением'
        /// </summary>
        [DataMember(Name = "with-electronic-notice")]
        public bool? WithElectronicNotice { get; set; }

        /// <summary>
        /// С товарами (для ЕМС международного)
        /// </summary>
        [DataMember(Name = "with-goods")]
        public bool? WithGoods { get; set; }

        /// <summary>
        /// Отметка 'С заказным уведомлением'
        /// </summary>
        [DataMember(Name = "with-order-of-notice")]
        public bool? WithOrderOfNotice { get; set; }

        /// <summary>
        /// Отметка 'С простым уведомлением'
        /// </summary>
        [DataMember(Name = "with-simple-notice")]
        public bool? WithSimpleNotice { get; set; }

        /// <summary>
        /// Отметка "Без разряда"
        /// </summary>
        [DataMember(Name = "wo-mail-rank")]
        public bool? WithoutMailRank { get; set; }
    }
}
