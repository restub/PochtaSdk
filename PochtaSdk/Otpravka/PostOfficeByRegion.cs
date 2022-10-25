using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post offices by region/district/settlement name.
    /// Запрос для поиска ОПС по названию региона/района/населенного пункта.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOfficeByRegion
    {
        /// <summary>
        /// Область/край/республика, где расположен населённый пункт (например, Свердловская)
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Район, где расположен населённый пункт (для деревень, посёлков и т. д. — например, Сухоложский)
        /// </summary>
        [DataMember(Name = "district")]
        public string District { get; set; }

        /// <summary>
        /// Название населённого пункта (например Екатеринбург)
        /// </summary>
        [DataMember(Name = "settlement")]
        public string Settlement { get; set; }
    }
}
