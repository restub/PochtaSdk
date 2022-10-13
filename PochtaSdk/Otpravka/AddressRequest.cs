using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Address normalization request.
    /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
    /// </summary>
    [DataContract]
    public class AddressRequest
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "original-address")]
        public string OriginalAddress { get; set; }
    }
}
