using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office working time mode.
    /// Типы расписаний почтовых отделений.
    /// https://otpravka.pochta.ru/specification#/services-postoffice-nearby
    /// </summary>
    [DataContract]
    public enum PostOfficeWorkTimeMode
    {
        /// <summary>
        /// Все
        /// </summary>
        [EnumMember(Value = "ALL")]
        [Display(Name = "Все")]
        All,

        /// <summary>
        /// Круглосуточные
        /// </summary>
        [EnumMember(Value = "ROUND_THE_CLOCK")]
        [Display(Name = "Круглосуточные")]
        RoundTheClock,

        /// <summary>
        /// Работающие в данный момент
        /// </summary>
        [EnumMember(Value = "CURRENTLY_WORKING")]
        [Display(Name = "Работающие в данный момент")]
        CurrentlyWorking,

        /// <summary>
        /// Работающие в выходные
        /// </summary>
        [EnumMember(Value = "WORK_ON_WEEKENDS")]
        [Display(Name = "Работающие в выходные")]
        WorkOnWeekends,
    }
}
