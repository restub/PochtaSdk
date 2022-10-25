using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post offices by address response.
    /// Поиск ОПС по адресу.
    /// https://otpravka.pochta.ru/specification#/services-postoffice-by-address
    /// </summary>
    [DataContract]
    public class PostOfficeRequest
    {
        /// <summary>
        /// Индекс почтового отделения
        /// </summary>
        [IgnoreDataMember]
        public string PostalCode { get; set; }

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

        /// <summary>
        /// true: добавлять в ответ индекс УФПС для найдённого отделения, 
        /// false: не добавлять. Значение по-умолчанию: false.
        /// </summary>
        [DataMember(Name = "ufps-postal-code")]
        public bool? UfpsPostalCode { get; set; }
    }
}
