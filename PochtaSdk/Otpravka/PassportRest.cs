using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Rest options from post office passport.
    /// Опции перерыва работы почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportRest
    {
        /// <summary>
        /// Начало перерыва, HH:MM.
        /// </summary>
        [DataMember(Name = "st")]
        public string Start { get; set; }

        /// <summary>
        /// Окончание перерыва, HH:MM.
        /// </summary>
        [DataMember(Name = "fn")]
        public string Finish { get; set; }
    }
}
