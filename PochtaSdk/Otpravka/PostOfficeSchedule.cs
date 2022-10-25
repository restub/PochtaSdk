using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office working hours.
    /// Расписание почтового отделения.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    /// <remarks>
    /// Структура не соответствует документации!
    /// Сервис возвращает расписание так, как представлено ниже.
    /// </remarks>
    [DataContract]
    public class PostOfficeSchedule
    {
        ///// <summary>
        ///// Перерывы - структура не документирована
        ///// </summary>
        //[DataMember(Name = "lunches")]
        //public object[] Lunches { get; set; }

        ///// <summary>
        ///// Наименование дня в неделе
        ///// </summary>
        //[DataMember(Name = "weekday-name")]
        //public string WeekdayName { get; set; }

        /// <summary>
        /// Номер дня в неделе
        /// </summary>
        [DataMember(Name = "weekday-id")]
        public int WeekdayID { get; set; }

        /// <summary>
        /// Начало работы
        /// </summary>
        [DataMember(Name = "begin-worktime")]
        public string BeginWorkTime { get; set; }

        /// <summary>
        /// Конец работы
        /// </summary>
        [DataMember(Name = "end-worktime")]
        public string EndWorkTime { get; set; }
    }
}
