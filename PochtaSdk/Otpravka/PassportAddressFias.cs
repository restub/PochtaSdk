using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// FIAS Address from post office passport.
    /// Адрес по ФИАС почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportAddressFias
    {
        /// <summary>
        /// Адрес в текстовом виде.
        /// </summary>
        [DataMember(Name = "ads")]
        public string Address { get; set; }

        [DataMember(Name = "addGarCode")]
        public string AddGarCode { get; set; }

        [DataMember(Name = "locationGarCode")]
        public string LocationGarCode { get; set; }

        [DataMember(Name = "regGarId")]
        public string RegGarId { get; set; }
    }
}
