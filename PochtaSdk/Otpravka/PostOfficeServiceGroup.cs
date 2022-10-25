using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office service group.
    /// Группы сервисов почтового отделения.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOfficeServiceGroup
    {
        /// <summary>
        /// Код группы
        /// </summary>
        [DataMember(Name = "group-id")]
        public int GroupID { get; set; }

        /// <summary>
        /// Название группы
        /// </summary>
        [DataMember(Name = "group-name")]
        public string GroupName { get; set; }
    }
}
