using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Full name normalization response.
    /// Нормализованные ФИО.
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
    /// </summary>
    [DataContract]
    public class FullName
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "middle-name")]
        public string MiddleName { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "original-fio")]
        public string OriginalFullName { get; set; }

        [DataMember(Name = "quality-code")]
        public FullNameQuality QualityCode { get; set; }

        [DataMember(Name = "surname")]
        public string Surname { get; set; }
    }
}
