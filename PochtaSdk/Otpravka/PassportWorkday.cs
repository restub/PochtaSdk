using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Workday options from post office passport.
    /// Опции рабочих дней почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportWorkday
    {
        /// <summary>
        /// Дата.
        /// </summary>
        [DataMember(Name = "dt")]
        public string Date { get; set; }

        /// <summary>
        /// Начало работы, HH:MM.
        /// </summary>
        [DataMember(Name = "st")]
        public string Start { get; set; }

        /// <summary>
        /// Окончание работы, HH:MM.
        /// </summary>
        [DataMember(Name = "fn")]
        public string Finish { get; set; }

        /// <summary>
        /// Число?
        /// </summary>
        [DataMember(Name = "nm")]
        public int Number { get; set; }

        /// <summary>
        /// Перерывы в работе
        /// </summary>
        [DataMember(Name = "rst")]
        public PassportRest[] Rests { get; set; }
    }
}
