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
        WithoutRank,

        /// <summary>
        /// Правительственное
        /// </summary>
        [EnumMember(Value = "GOVERNMENTAL")]
        Governmental,

        /// <summary>
        /// Воинское
        /// </summary>
        [EnumMember(Value = "MILITARY")]
        Military,

        /// <summary>
        /// Служебное
        /// </summary>
        [EnumMember(Value = "OFFICIAL")]
        Official,

        /// <summary>
        /// Судебное
        /// </summary>
        [EnumMember(Value = "JUDICIAL")]
        Judicial,

        /// <summary>
        /// Президентское
        /// </summary>
        [EnumMember(Value = "PRESIDENTIAL")]
        Presidential,

        /// <summary>
        /// Кредитное
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        Credit,

        /// <summary>
        /// Административное
        /// </summary>
        [EnumMember(Value = "ADMINISTRATIVE")]
        Administrative,
    }
}