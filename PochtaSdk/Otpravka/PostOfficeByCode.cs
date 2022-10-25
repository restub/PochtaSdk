using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post offices by postal code request.
    /// Запрос для поиска ОПС по индексу.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOfficeByCode : PostOfficeRequestBase
    {
        /// <summary>
        /// Индекс почтового отделения
        /// </summary>
        [IgnoreDataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// true: добавлять в ответ индекс УФПС для найдённого отделения, 
        /// false: не добавлять. Значение по-умолчанию: false.
        /// </summary>
        [DataMember(Name = "ufps-postal-code")]
        public bool? UfpsPostalCode { get; set; }
    }
}
