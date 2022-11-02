using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping rate response.
    /// Расчет стоимости пересылки, класс ответа.
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public class ShippingRateResponse
    {
        /// <summary>
        /// Плата за Авиа-пересылку (коп)
        /// </summary>
        [DataMember(Name = "avia-rate")]
        public ShippingRateAmounts AviaRate { get; set; }

        /// <summary>
        /// Плата за "Проверку комплектности" (коп)
        /// </summary>
        [DataMember(Name = "completeness-checking-rate")]
        public ShippingRateAmounts CompletenessCheckingRate { get; set; }

        /// <summary>
        /// Плата за "Проверку вложений" (коп)
        /// </summary>
        [DataMember(Name = "contents-checking-rate")]
        public ShippingRateAmounts ContentsCheckingRate { get; set; }

        /// <summary>
        /// Время доставки
        /// </summary>
        [DataMember(Name = "delivery-time")]
        public ShippingDeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Надбавка за отметку "Осторожно/Хрупкое"
        /// </summary>
        [DataMember(Name = "fragile-rate")]
        public ShippingRateAmounts FragileRate { get; set; }

        /// <summary>
        /// Плата за пересылку (коп)
        /// </summary>
        [DataMember(Name = "ground-rate")]
        public ShippingRateAmounts GroundRate { get; set; }

        /// <summary>
        /// Плата за объявленную ценность (коп)
        /// </summary>
        [DataMember(Name = "insurance-rate")]
        public ShippingRateAmounts InsuranceRate { get; set; }

        /// <summary>
        /// Плата за "Опись вложения" (коп)
        /// </summary>
        [DataMember(Name = "inventory-rate")]
        public ShippingRateAmounts InventoryRate { get; set; }

        /// <summary>
        /// Способ оплаты уведомеления
        /// </summary>
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod NoticePaymentMethod { get; set; }

        /// <summary>
        /// Надбавка за уведомление о вручении
        /// </summary>
        [DataMember(Name = "notice-rate")]
        public ShippingRateAmounts NoticeRate { get; set; }

        /// <summary>
        /// Надбавка за уведомление о вручении
        /// </summary>
        [DataMember(Name = "oversize-rate")]
        public ShippingRateAmounts OversizeRate { get; set; }

        /// <summary>
        /// Способ оплаты
        /// </summary>
        [DataMember(Name = "payment-method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Плата за "Пакет смс получателю" (коп)
        /// </summary>
        [DataMember(Name = "sms-notice-recipient-rate")]
        public ShippingRateAmounts SmsNoticeRate { get; set; }

        /// <summary>
        /// Плата всего без НДС (коп)
        /// </summary>
        [DataMember(Name = "total-rate")]
        public int TotalRate { get; set; }

        /// <summary>
        /// Всего НДС (коп)
        /// </summary>
        [DataMember(Name = "total-vat")]
        public int TotalVat { get; set; }

        /// <summary>
        /// Плата за "Возврат сопроводительных документов" (коп)
        /// </summary>
        [DataMember(Name = "vsd-rate")]
        public ShippingRateAmounts DocumentReturnRate { get; set; }
    }
}
