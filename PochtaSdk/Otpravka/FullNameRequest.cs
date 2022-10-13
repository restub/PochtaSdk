using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Full name normalization request.
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
    /// </summary>
    [DataContract]
    public class FullNameRequest
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "original-fio")]
        public string OriginalFullName { get; set; }
    }
}
