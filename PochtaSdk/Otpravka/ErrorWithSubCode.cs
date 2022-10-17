using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error with sub-code.
    /// Код, субкод и описание ошибки.
    /// https://otpravka.pochta.ru/specification#/orders-search_order
    /// </summary>
    [DataContract]
    public class ErrorWithSubCode : IHasErrors
    {
        /// <summary>
        /// Целочисленный код ошибки.
        /// </summary>
        [DataMember(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DataMember(Name = "desc")]
        public string Description { get; set; }

        /// <summary>
        /// Субкод ошибки
        /// </summary>
        [DataMember(Name = "sub-code")]
        public string SubCode { get; set; }

        /// <inheritdoc/>
        public string GetErrorMessage() => Description;

        /// <inheritdoc/>
        public bool HasErrors() => !string.IsNullOrWhiteSpace(Description);
    }
}