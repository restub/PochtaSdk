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

        [DataMember(Name = "customs-code")]
        public string CustomsCode { get; set; }

        [DataMember(Name = "ioss-code")]
        public string IossCode { get; set; }

        /// <summary>
        /// Список вложений
        /// </summary>
        [DataMember(Name = "customs-entries")]
        public CustomsEntry[] CustomsEntries { get; set; }

        [DataMember(Name = "entries-type")]
        public string EntriesType { get; set; }

        [DataMember(Name = "invoice-number")]
        public string InvoiceNumber { get; set; }

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
    }
}