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
    public class ShippingPointReturnAddress
    {
        /// <summary>
        /// Недокументировано: адрес возврата указан явным образом
        /// </summary>
        [DataMember(Name = "manual-address-input")]
        public bool ManualAddressInput { get; set; }

        // где-то тут еще должен быть сам адрес
    }
}
