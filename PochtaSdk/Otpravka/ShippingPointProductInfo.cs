using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping point product information.
    /// Информация о доступной услуге точки сдачи (почтового отделения).
    /// https://otpravka.pochta.ru/specification#/settings-shipping_points
    /// </summary>
    /// <remarks>
    /// Недокументированная структура!
    /// </remarks>
    [DataContract]
    public class ShippingPointProductInfo
    {
        /// <summary>
        /// Категория отправления (обычное, заказное, с объявленной ценностью)
        /// </summary>
        [DataMember(Name = "mail-category")]
        public MailCategory MailCategory { get; set; }

        /// <summary>
        /// Тип отправления (письмо, посылка, бандероль, EMS)
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

        /// <summary>
        /// Тип продукта (комбинация категории и типа отправления).
        /// </summary>
        [DataMember(Name = "product-type")]
        public string ProductType { get; set; }
    }
}
