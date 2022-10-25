using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office services.
    /// Услуги почтового отделения.
    /// https://otpravka.pochta.ru/specification#/services-postoffice-service
    /// https://otpravka.pochta.ru/specification#/services-postoffice-service-group
    /// </summary>
    [DataContract]
    public class PostOfficeService
    {
        /// <summary>
        /// Group identity
        /// Код группы
        /// </summary>
        [DataMember(Name = "group-id")]
        public int GroupID { get; set; }

        /// <summary>
        /// Service code
        /// Код услуги
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Service name
        /// Название услуги
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
