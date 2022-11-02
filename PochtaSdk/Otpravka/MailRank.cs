using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Mail rank
    /// Разряд письма
    /// https://otpravka.pochta.ru/specification#/enums-base-mail-rank
    /// </summary>
    [DataContract]
    public enum MailRank
    {
        /// <summary>
        /// Без разряда
        /// </summary>
        [EnumMember(Value = "WO_RANK")]
        [Display(Name = "Без разряда")]
        WithoutRank,

        /// <summary>
        /// Правительственное
        /// </summary>
        [EnumMember(Value = "GOVERNMENTAL")]
        [Display(Name = "Правительственное")]
        Governmental,

        /// <summary>
        /// Воинское
        /// </summary>
        [EnumMember(Value = "MILITARY")]
        [Display(Name = "Воинское")]
        Military,

        /// <summary>
        /// Служебное
        /// </summary>
        [EnumMember(Value = "OFFICIAL")]
        [Display(Name = "Служебное")]
        Official,

        /// <summary>
        /// Судебное
        /// </summary>
        [EnumMember(Value = "JUDICIAL")]
        [Display(Name = "Судебное")]
        Judicial,

        /// <summary>
        /// Президентское
        /// </summary>
        [EnumMember(Value = "PRESIDENTIAL")]
        [Display(Name = "Президентское")]
        Presidential,

        /// <summary>
        /// Кредитное
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        [Display(Name = "Кредитное")]
        Credit,

        /// <summary>
        /// Административное
        /// </summary>
        [EnumMember(Value = "ADMINISTRATIVE")]
        [Display(Name = "Административное")]
        Administrative,
    }
}