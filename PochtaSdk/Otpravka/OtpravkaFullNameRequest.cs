using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    [DataContract]
    public class OtpravkaFullNameRequest
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "original-fio")]
        public string OriginalFullName { get; set; }
    }
}
