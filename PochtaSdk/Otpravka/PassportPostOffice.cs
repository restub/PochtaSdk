using System.Runtime.Serialization;
using Newtonsoft.Json;
using Restub.Toolbox;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office from post office passport.
    /// Почтовое отделение из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportPostOffice
    {
        /// <summary>
        /// Адрес отделения.
        /// </summary>
        [DataMember(Name = "address")]
        public PassportAddress Address { get; set; }

        /// <summary>
        /// Адрес отделения в ФИАС.
        /// </summary>
        [DataMember(Name = "addressFias")]
        public PassportAddressFias AddressFias { get; set; }

        /// <summary>
        /// Доступность ECOM.
        /// </summary>
        [DataMember(Name = "ecom"), JsonConverter(typeof(BoolIntConverter))]
        public bool Ecom { get; set; }

        /// <summary>
        /// Опции ECOM.
        /// </summary>
        [DataMember(Name = "ecomOptions")]
        public PassportEcomOptions EcomOptions { get; set; }

        /// <summary>
        /// Выходные дни.
        /// </summary>
        [DataMember(Name = "holidays")]
        public PassportHoliday[] Holidays { get; set; }

        /// <summary>
        /// Широта.
        /// </summary>
        [DataMember(Name = "latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// </summary>
        [DataMember(Name = "longitude")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Доступность онлайн-посылок.
        /// </summary>
        [DataMember(Name = "onlineParcel"), JsonConverter(typeof(BoolIntConverter))]
        public bool OnlineParcel { get; set; }

        /// <summary>
        /// Тип отделения.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Расписание работы отделения.
        /// </summary>
        [DataMember(Name = "workTime")]
        public string[] WorkTime { get; set; }
    }
}
