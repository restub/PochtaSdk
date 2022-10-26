using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Customs declaration for international shippings.
    /// Таможенная декларация (для международных отправлений).
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class CustomsDeclaration
    {
        /// <summary>
        /// Сертификаты, сопровождающие отправление
        /// </summary>
        [DataMember(Name = "certificate-number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// Код валюты.
        /// </summary>
        [DataMember(Name = "currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// Код таможенного органа
        /// </summary>
        [DataMember(Name = "customs-code")]
        public string CustomsCode { get; set; }

        /// <summary>
        /// Список вложений
        /// </summary>
        [DataMember(Name = "customs-entries")]
        public PackageEntry[] CustomsEntries { get; set; }

        /// <summary>
        /// Категория вложения.
        /// </summary>
        [DataMember(Name = "entries-type")]
        public PackageEntryType? EntriesType { get; set; }

        /// <summary>
        /// Счет (номер счета-фактуры)
        /// </summary>
        [DataMember(Name = "invoice-number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Регистрационный код продавца
        /// </summary>
        [DataMember(Name = "ioss-code")]
        public string IossCode { get; set; }

        /// <summary>
        /// Лицензии, сопровождающие отправление
        /// </summary>
        [DataMember(Name = "license-number")]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// Приложенные документы: сертификат
        /// </summary>
        [DataMember(Name = "with-certificate")]
        public bool WithCertificate { get; set; }

        /// <summary>
        /// Приложенные документы: счет-фактура
        /// </summary>
        [DataMember(Name = "with-invoice")]
        public bool WithInvoice { get; set; }

        /// <summary>
        /// Приложенные документы: лицензия
        /// </summary>
        [DataMember(Name = "with-license")]
        public bool WithLicense { get; set; }

        // ----------------------

        /// <summary>
        /// Комментарии (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Комментарии таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "customs-comments")]
        public string CustomsComments { get; set; }

        /// <summary>
        /// Решение таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "customs-decision")]
        public CustomsDecision? CustomsDecision { get; set; }

        /// <summary>
        /// Дата решения таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "decision-date")]
        public string DecisionDate { get; set; }

        /// <summary>
        /// Описание решения таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "decision-description")]
        public string DecisionDescription { get; set; }

        /// <summary>
        /// Ошибка декларирования (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "fts-error")]
        public string FtsError { get; set; }

        /// <summary>
        /// Описание рекомендации таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "recom-description")]
        public string RecommendationDescription { get; set; }

        /// <summary>
        /// Дата регистрации документа таможенного органа (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "registration-date")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Статус декларации в процессе электронного декларирования (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "status")]
        public CustomsDeclarationStatus? Status { get; set; }
    }
}