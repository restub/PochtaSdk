using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Fiscal payment.
    /// Средства, использованные при оплате.
    /// https://otpravka.pochta.ru/specification#/orders-search_order_byid
    /// </summary>
    [DataContract]
    public class FiscalPayment
    {
        /// <summary>
        /// Сумма оплаты платежным средством,(копейки)
        /// </summary>
        [DataMember(Name = "payment-amount")]
        public int? PaymentAmount { get; set; }

        /// <summary>
        /// Вид платежного средства
        /// </summary>
        [DataMember(Name = "payment-kind")]
        public int? PaymentKind { get; set; }

        /// <summary>
        /// Тип платежного средства
        /// </summary>
        [DataMember(Name = "payment-type")]
        public int? PaymentType { get; set; }
    }
}