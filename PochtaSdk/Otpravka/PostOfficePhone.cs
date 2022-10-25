using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office phone.
    /// Телефон почтового отделения.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOfficePhone
    {
        /// <summary>
        /// Является ли телефон факсом
        /// </summary>
        [DataMember(Name = "is-fax")]
        public bool IsFax { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [DataMember(Name = "phone-number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Код города
        /// </summary>
        [DataMember(Name = "phone-town-code")]
        public string PhoneTownCode { get; set; }

        /// <summary>
        /// Тип телефонного номера
        /// </summary>
        [DataMember(Name = "phone-type-name")]
        public string PhoneTypeName { get; set; }
    }
}
