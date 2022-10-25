using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office holiday.
    /// Выходной почтового отделения.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOfficeHoliday
    {
        /// <summary>
        /// Дата.
        /// </summary>
        [DataMember(Name = "date")]
        public string Date { get; set; }

        /// <summary>
        /// Время работы (Опционально). Рабочий день
        /// </summary>
        [DataMember(Name = "schedule")]
        public PostOfficeSchedule Schedule { get; set; }
    }
}
