using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address from post office passport.
    /// Адрес почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportAddress
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
        /// Адрес введен вручную.
        /// </summary>
        [DataMember(Name = "manualInput")]
        public bool ManualInput { get; set; }

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
        /// Часть адреса: Улица
        /// </summary>
        [DataMember(Name = "street")]
        public string Street { get; set; }

        /// <summary>
        /// Часть здания: Корпус
        /// </summary>
        [DataMember(Name = "corpus")]
        public string Corpus { get; set; }

        /// <summary>
        /// Микрорайон
        /// </summary>
        [DataMember(Name = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Часть здания: Строение
        /// </summary>
        [DataMember(Name = "building")]
        public string Building { get; set; }

        /// <summary>
        /// Часть здания: Офис
        /// </summary>
        [DataMember(Name = "office")]
        public string Office { get; set; }

        // --- эти свойства присутствуют в обычных адресах,
        // --- но неизвестно, могут ли встретиться в выгрузке

        /// <summary>
        /// Часть адреса: Владение
        /// </summary>
        [DataMember(Name = "vladenie")]
        public string Vladenie { get; set; }

        /// <summary>
        /// Часть здания: Литера
        /// </summary>
        [DataMember(Name = "letter")]
        public string Letter { get; set; }

        /// <summary>
        /// Часть здания: Дробь
        /// </summary>
        [DataMember(Name = "slash")]
        public string Slash { get; set; }
    }
}
