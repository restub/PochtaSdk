using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Phone number normalization response.
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
    /// </summary>
    [DataContract]
    public class PhoneRequest
    {
        /// <summary>
        /// Область/край трелефонного номера
        /// </summary>
        [DataMember(Name = "area")]
        public string Area { get; set; }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой
        /// </summary>
        [DataMember(Name = "original-phone")]
        public string OriginalPhone { get; set; }

        /// <summary>
        /// Город телефонного номера
        /// </summary>
        [DataMember(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Регион телефонного номера
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }
    }
}