using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post office request base.
    /// Базовый класс запроса для поиска ОПС.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// https://otpravka.pochta.ru/specification#/services-postoffice-nearby
    /// </summary>
    [DataContract]
    public class PostOfficeRequestBase
    {
        /// <summary>
        /// Широта
        /// </summary>
        [DataMember(Name = "latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        [DataMember(Name = "longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Текущее время в формате yyyy-MM-dd'T'HH:mm:ss (Опционально)
        /// </summary>
        [DataMember(Name = "current-date-time")]
        public DateTime? CurrentDateTime { get; set; }

        /// <summary>
        /// Фильтр по типам объектов в ответе.
        /// true: ГОПС, СОПС, ПОЧТОМАТ. 
        /// false: все.
        /// Значение по-умолчанию - true.
        /// </summary>
        [DataMember(Name = "filter-by-office-type")]
        public bool? FilterByOfficeType { get; set; }
    }
}
