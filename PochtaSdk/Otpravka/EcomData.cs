using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// ECOM shipping data.
    /// Данные отправления ЕКОМ.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class EcomData
    {
        /// <summary>
        /// Идентификатор пункта выдачи заказов
        /// </summary>
        [DataMember(Name = "delivery-point-index")]
        public string DeliveryPointIndex { get; set; }

        /// <summary>
        /// Методы идентификации
        /// </summary>
        [DataMember(Name = "identity-methods")]
        public IdentityMethod[] IdentityMethods { get; set; }

        /// <summary>
        /// Сервисы ЕКОМ.
        /// </summary>
        [DataMember(Name = "services")]
        public EcomService[] Services { get; set; }
    }
}