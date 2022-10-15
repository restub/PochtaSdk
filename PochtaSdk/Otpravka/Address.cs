using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address, normalized address, return address.
    /// Адрес, нормализованный адрес, адрес возврата.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Тип адреса
        /// https://otpravka.pochta.ru/specification#/enums-base-address-type
        /// </summary>
        [DataMember(Name = "address-type")]
        public AddressType AddressType { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        [DataMember(Name = "area")]
        public string Area { get; set; }

        /// <summary>
        /// Часть здания: Строение
        /// </summary>
        [DataMember(Name = "building")]
        public string Building { get; set; }

        /// <summary>
        /// Часть здания: Корпус
        /// </summary>
        [DataMember(Name = "corpus")]
        public string Corpus { get; set; }

        /// <summary>
        /// Название гостиницы
        /// </summary>
        [DataMember(Name = "hotel")]
        public string Hotel { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания
        /// </summary>
        [DataMember(Name = "house")]
        public string House { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        [DataMember(Name = "index")]
        public string PostCode { get; set; }

        /// <summary>
        /// Часть здания: Литера
        /// </summary>
        [DataMember(Name = "letter")]
        public string Letter { get; set; }

        /// <summary>
        /// Микрорайон
        /// </summary>
        [DataMember(Name = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта
        /// </summary>
        [DataMember(Name = "num-address-type")]
        public string NumAddressType { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        [DataMember(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Область, регион
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения
        /// </summary>
        [DataMember(Name = "room")]
        public string Room { get; set; }

        /// <summary>
        /// Часть здания: Дробь
        /// </summary>
        [DataMember(Name = "slash")]
        public string Slash { get; set; }

        /// <summary>
        /// Часть адреса: Улица
        /// </summary>
        [DataMember(Name = "street")]
        public string Street { get; set; }

        /// <summary>
        /// Часть здания: Офис
        /// </summary>
        [DataMember(Name = "office")]
        public string Office { get; set; }

        /// <summary>
        /// Часть адреса: Владение
        /// </summary>
        [DataMember(Name = "vladenie")]
        public string Vladenie { get; set; }
    }
}
