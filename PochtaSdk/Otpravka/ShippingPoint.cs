using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping point.
    /// Точки сдачи (почтовые отделения для приема отправлений).
    /// https://otpravka.pochta.ru/specification#/settings-shipping_points
    /// </summary>
    [DataContract]
    public class ShippingPoint
    {
        /// <summary>
        /// Признак активации
        /// </summary>
        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Индекс почтового отделения обслуживания
        /// </summary>
        [DataMember(Name = "operator-postcode")]
        public string OperatorPostCode { get; set; }

        /// <summary>
        /// Адрес ОПС
        /// </summary>
        [DataMember(Name = "ops-address")]
        public string PostOfficeAddress { get; set; }

        /// <summary>
        /// Недокументировано: дополнительный индекс ОПС
        /// </summary>
        [DataMember(Name = "additional-operator-postcode")]
        public string AdditionalOperatorPostcode { get; set; }

        /// <summary>
        /// Недокументировано: дополнительные индексы ОПС
        /// </summary>
        [DataMember(Name = "additional-operator-postcodes")]
        public string[] AdditionalOperatorPostcodes { get; set; }

        /// <summary>
        /// Недокументировано: доступные дополнительные индексы ОПС
        /// </summary>
        [DataMember(Name = "available-additional-operator-postcodes")]
        public string[] AvailableAdditionalOperatorPostcodes { get; set; }

        /// <summary>
        /// Недокументировано: доступные в ОПС типы отправлений
        /// </summary>
        [DataMember(Name = "available-mail-types")]
        public MailType[] AvailableMailTypes { get; set; }

        /// <summary>
        /// Недокументировано: доступные в отделении продукты (типы и категории отправлений)
        /// </summary>
        [DataMember(Name = "available-products")]
        public ShippingPointProductInfo[] AvailableProducts { get; set; }

        /// <summary>
        /// Недокументировано: вызов курьера
        /// </summary>
        [DataMember(Name = "courier-call")]
        public bool CourierCall { get; set; }

        /// <summary>
        /// Недокументировано: предпочтовая подготовка
        /// </summary>
        [DataMember(Name = "pre-postal-preparation")]
        public bool PrePostalPreparation { get; set; }

        /// <summary>
        /// Недокументировано: тип адреса возврата
        /// </summary>
        [DataMember(Name = "return-address-type")]
        public ReturnAddressType ReturnAddressType { get; set; }

        /// <summary>
        /// Недокументировано: типы отправлений, доступные пользователю
        /// </summary>
        [DataMember(Name = "user-available-mail-types")]
        public MailType[] UserAvailableMailTypes { get; set; }

        /// <summary>
        /// Недокументировано: типы продуктов, доступные пользователю
        /// </summary>
        [DataMember(Name = "user-available-products")]
        public ShippingPointProductInfo[] UserAvailableProducts { get; set; }

        /// <summary>
        /// Недокументировано: адрес возврата пользователя
        /// </summary>
        [DataMember(Name = "user-return-address")]
        public ShippingPointReturnAddress UserReturnAddress { get; set; }

        /// <summary>
        /// Недокументировано: возврат сопроводительных документов (ВСД) доступен
        /// </summary>
        [DataMember(Name = "vsd-enabled")]
        public bool VsdEnabled { get; set; }
    }
}
