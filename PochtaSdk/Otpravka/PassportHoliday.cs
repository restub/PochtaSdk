using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Holiday options from post office passport.
    /// Опции нерабочих дней почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportHoliday
    {
        /// <summary>
        /// Дата начала.
        /// </summary>
        [DataMember(Name = "ds")]
        public string DateStart { get; set; }

        /// <summary>
        /// Дата окончания.
        /// </summary>
        [DataMember(Name = "df")]
        public string DateFinish { get; set; }

        /// <summary>
        /// Рабочие дни.
        /// </summary>
        [DataMember(Name = "work")]
        public PassportWorkday[] WorkDays { get; set; }
    }
}
