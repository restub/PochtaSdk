using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order, normal version.
    /// Заказ, обычная версия. Используется при создании заказов-отправлений.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class Order : OrderBase
    {
        /// <summary>
        /// Тип адреса
        /// </summary>
        [DataMember(Name = "address-type-to")]
        public AddressType AddressTypeTo { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        [DataMember(Name = "area-to")]
        public string AreaTo { get; set; }

        /// <summary>
        /// Часть здания: Строение
        /// </summary>
        [DataMember(Name = "building-to")]
        public string BuildingTo { get; set; }

        /// <summary>
        /// Часть здания: Корпус
        /// </summary>
        [DataMember(Name = "corpus-to")]
        public string CorpusTo { get; set; }

        /// <summary>
        /// Название гостиницы
        /// </summary>
        [DataMember(Name = "hotel-to")]
        public string HotelTo { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания
        /// </summary>
        [DataMember(Name = "house-to")]
        public string HouseTo { get; set; }

        /// <summary>
        /// Целое число (Опционально) Почтовый индекс,
        /// для отправлений адресованных в почтомат или пункт выдачи,
        /// должен использоваться объект "ecom-data"
        /// </summary>
        [DataMember(Name = "index-to")]
        public int? PostCodeTo { get; set; }

        /// <summary>
        /// Часть здания: Литера
        /// </summary>
        [DataMember(Name = "letter-to")]
        public string LetterTo { get; set; }

        /// <summary>
        /// Микрорайон
        /// </summary>
        [DataMember(Name = "location-to")]
        public string LocationTo { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта
        /// </summary>
        [DataMember(Name = "num-address-type-to")]
        public string NumAddressTypeTo { get; set; }

        /// <summary>
        /// Часть здания: Офис
        /// </summary>
        [DataMember(Name = "office-to")]
        public string OfficeTo { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        [DataMember(Name = "place-to")]
        public string PlaceTo { get; set; }

        /// <summary>
        /// Область, регион
        /// </summary>
        [DataMember(Name = "region-to")]
        public string RegionTo { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения
        /// </summary>
        [DataMember(Name = "room-to")]
        public string RoomTo { get; set; }

        /// <summary>
        /// Часть здания: Дробь
        /// </summary>
        [DataMember(Name = "slash-to")]
        public string SlashTo { get; set; }

        /// <summary>
        /// Почтовый индекс (буквенно-цифровой)
        /// </summary>
        [DataMember(Name = "str-index-to")]
        public string StrPostCodeTo { get; set; }

        /// <summary>
        /// Часть адреса: Улица
        /// </summary>
        [DataMember(Name = "street-to")]
        public string StreetTo { get; set; }

        /// <summary>
        /// Часть здания: Владение
        /// </summary>
        [DataMember(Name = "vladenie-to")]
        public string VladenieTo { get; set; }
    }
}
