using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address normalization response.
    /// Ответ метода нормализации адреса.
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
    /// </summary>
    [DataContract]
    public class AddressClean : Address
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальный адрес одной строкой
        /// </summary>
        [DataMember(Name = "original-address")]
        public string OriginalAddress { get; set; }

        /// <summary>
        /// Код качества нормализации адреса
        /// </summary>
        [DataMember(Name = "quality-code")]
        public AddressQuality QualityCode { get; set; }

        /// <summary>
        /// Код проверки нормализации адреса
        /// </summary>
        [DataMember(Name = "validation-code")]
        public AddressValidation ValidationCode { get; set; }

        /// <summary>
        /// Guid региона
        /// </summary>
        [DataMember(Name = "region-guid")]
        public string RegionGuid { get; set; }

        /// <summary>
        /// Guid населенного пункта
        /// </summary>
        [DataMember(Name = "place-guid")]
        public string PlaceGuid { get; set; }

        /// <summary>
        /// Guid улицы
        /// </summary>
        [DataMember(Name = "street-guid")]
        public string StreetGuid { get; set; }

        /// <summary>
        /// Guid адреса
        /// </summary>
        [DataMember(Name = "address-guid")]
        public string AddressGuid { get; set; }
    }
}
