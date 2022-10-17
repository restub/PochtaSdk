using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Fiscal data.
    /// Фискальные данные.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class FiscalData
    {
        /// <summary>
        /// Адрес электронной почты плательщика
        /// </summary>
        [DataMember(Name = "customer-email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// ИНН юридического лица покупателя
        /// </summary>
        [DataMember(Name = "customer-inn")]
        public string CustomerInn { get; set; }

        /// <summary>
        /// Наименование юридического лица покупателя
        /// </summary>
        [DataMember(Name = "customer-name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Телефон плательщика
        /// </summary>
        [DataMember(Name = "customer-phone")]
        public int? CustomerPhone { get; set; }

        /// <summary>
        /// Сумма предоплаты (копейки)
        /// </summary>
        [DataMember(Name = "payment-amount")]
        public int? PaymentAmount { get; set; }

        // --------------------

        /// <summary>
        /// Средства, использованные при оплате (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "fiscal-payments")]
        public FiscalPayment[] FiscalPayments { get; set; }
    }
}