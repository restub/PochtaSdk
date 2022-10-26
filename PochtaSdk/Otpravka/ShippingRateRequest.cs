using System.Runtime.Serialization;
using PochtaSdk.Tariff;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping rate request.
    /// Расчет стоимости пересылки, класс запроса.
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public class ShippingRateRequest
    {
        /// <summary>
        /// Признак услуги проверки комплектности
        /// </summary>
        [DataMember(Name = "completeness-checking")]
        public bool CompletenessChecking { get; set; }

        /// <summary>
        /// Признак услуги проверки вложения
        /// </summary>
        [DataMember(Name = "contents-checking")]
        public bool ContentsChecking { get; set; }

        /// <summary>
        /// Отметка "Курьер"
        /// </summary>
        [DataMember(Name = "courier")]
        public bool Courier { get; set; }

        /// <summary>
        /// Объявленная ценность
        /// </summary>
        [DataMember(Name = "declared-value")]
        public int DeclaredValue { get; set; }

        /// <summary>
        /// Идентификатор пункта выдачи заказов
        /// </summary>
        [DataMember(Name = "delivery-point-index")]
        public string DeliveryPointPostCode { get; set; }

        /// <summary>
        /// Линейные размеры
        /// </summary>
        [DataMember(Name = "dimension")]
        public Dimensions Dimension { get; set; }

        /// <summary>
        /// Типоразмер
        /// </summary>
        [DataMember(Name = "dimension-type")]
        public DimensionType DimensionType { get; set; }

        /// <summary>
        /// Категория вложения
        /// </summary>
        [DataMember(Name = "entries-type")]
        public PackageEntryType EntriesType { get; set; }

        /// <summary>
        /// Отметка "Осторожно/Хрупко"
        /// </summary>
        [DataMember(Name = "fragile")]
        public bool Fragile { get; set; }

        /// <summary>
        /// Почтовый индекс объекта почтовой связи места приема
        /// </summary>
        [DataMember(Name = "index-from")]
        public string PostCodeFrom { get; set; }

        /// <summary>
        /// Почтовый индекс объекта почтовой связи места назначения
        /// </summary>
        [DataMember(Name = "index-to")]
        public string PostCodeTo { get; set; }

        /// <summary>
        /// Опись вложения
        /// </summary>
        [DataMember(Name = "inventory")]
        public bool Inventory { get; set; }

        /// <summary>
        /// Категория РПО
        /// </summary>
        [DataMember(Name = "mail-category")]
        public MailCategory MailCategory { get; set; }

        /// <summary>
        /// Код страны назначения
        /// </summary>
        [DataMember(Name = "mail-direct")]
        public OksmCountryCode CountryCode { get; set; } = OksmCountryCode.Russia;

        /// <summary>
        /// Вид РПО
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

        /// <summary>
        /// Масса отправления в граммах
        /// </summary>
        [DataMember(Name = "mass")]
        public int Mass { get; set; }

        /// <summary>
        /// Способ оплаты уведомления
        /// </summary>
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod NoticePaymentMethod { get; set; }

        /// <summary>
        /// Способ оплаты
        /// </summary>
        [DataMember(Name = "payment-method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Признак услуги SMS уведомления
        /// </summary>
        [DataMember(Name = "sms-notice-recipient")]
        public int SmsNoticeRecipient { get; set; }

        /// <summary>
        /// Вид транспортировки
        /// </summary>
        [DataMember(Name = "transport-type")]
        public TransportType TransportType { get; set; }

        /// <summary>
        /// Возврат сопроводительныйх документов
        /// </summary>
        [DataMember(Name = "vsd")]
        public bool DocumentReturn { get; set; }

        /// <summary>
        /// Отметка 'С электронным уведомлением'
        /// </summary>
        [DataMember(Name = "with-electronic-notice")]
        public bool WithElectronicNotice { get; set; }

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
    }
}
