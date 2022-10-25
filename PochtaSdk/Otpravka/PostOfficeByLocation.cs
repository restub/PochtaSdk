using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post offices by location request.
    /// Запрос для поиска ОПС по координатам.
    /// https://otpravka.pochta.ru/specification#/services-postoffice-nearby
    /// </summary>
    [DataContract]
    public class PostOfficeByLocation : PostOfficeRequestBase
    {
        /// <summary>
        /// Количество ближайших почтовых отделений в результате поиска (Опционально)
        /// </summary>
        [DataMember(Name = "top")]
        public int? Top { get; set; }

        /// <summary>
        /// Дополнительное ограничение по времени работы для поиска ОПС.
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true)]
        public PostOfficeWorkTimeMode WorkTimeFilter { get; set; }

        /// <summary>
        /// Радиус для поиска, в километрах (Опционально)
        /// </summary>
        [DataMember(Name = "search-radius")]
        public decimal? SearchRadius { get; set; }

        /// <summary>
        /// Исключать не публичные отделения (Опционально).
        /// По-умолчанию не исключать (false).
        /// </summary>
        [DataMember(Name = "hide-private")]
        public bool? HidePrivate { get; set; }

        /// <summary>
        /// Адрес в том формате, в котором возвращает его сервис Яндекса для адреса, 
        /// указанного пользователем. Пример: Санкт-Петербург, улица Победы, 15к1. 
        /// Параметр необходим для определения является ли переданный адрес 
        /// точным адресом отделения. Требует также заполненного параметра geoObject.
        /// </summary>
        [DataMember(Name = "yandex-address")]
        public string YandexAddress { get; set; }

        /// <summary>
        /// JSON-строка, содержащая объект GeoObject, получаемый для адреса в сервисе Яндекса. 
        /// См. api.yandex.ru. Требует также заполненного параметра 'yandex-address'.
        /// </summary>
        [DataMember(Name = "geo-object")]
        public string GeoObject { get; set; }
    }
}
