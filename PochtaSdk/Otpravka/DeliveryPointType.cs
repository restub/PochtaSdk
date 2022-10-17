using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Delivery point type.
    /// Тип пункта выдачи.
    /// https://otpravka.pochta.ru/specification#/enums-delivery-point-type
    /// </summary>
    [DataContract]
    public enum DeliveryPointType
    {
        /// <summary>
        /// ПВЗ - пункт выдачи заказов
        /// </summary>
        [EnumMember(Value = "DELIVERY_POINT")]
        DeliveryPoint,

        /// <summary>
        /// АПС - автоматизированная почтовая станция (почтамат)
        /// </summary>
        [EnumMember(Value = "PICKUP_POINT")]
        PickupPoint,
    }
}
