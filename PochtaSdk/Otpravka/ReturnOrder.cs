using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Return order.
    /// Возврат отправления. Используется при создании заказов типа Легкий возврат.
    /// https://otpravka.pochta.ru/specification#/returns-create_without_direct
    /// </summary>
    [DataContract]
    public class ReturnOrder
    {
        /// <summary>
        /// Адрес отправителя
        /// </summary>
        [DataMember(Name = "address-from")]
        public Address AddressFrom { get; set; }

        /// <summary>
        /// Адрес назначения
        /// </summary>
        [DataMember(Name = "address-to")]
        public Address AddressTo { get; set; }

        /// <summary>
        /// Объявленная ценность (копейки)
        /// </summary>
        [DataMember(Name = "insr-value")]
        public int? DeclaredValue { get; set; }

        /// <summary>
        /// Вид РПО
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

        /// <summary>
        /// Номер заказа. Внешний идентификатор заказа, который формируется отправителем
        /// </summary>
        [DataMember(Name = "order-num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// Индекс места приема
        /// </summary>
        [DataMember(Name = "postoffice-code")]
        public string PostOfficeCode { get; set; }

        /// <summary>
        /// Наименование получателя одной строкой (ФИО, наименование организации)
        /// </summary>
        [DataMember(Name = "recipient-name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// Наименование отправителя одной строкой (ФИО, наименование организации)
        /// </summary>
        [DataMember(Name = "sender-name")]
        public string SenderName { get; set; }
    }
}
