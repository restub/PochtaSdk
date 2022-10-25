using System.Runtime.Serialization;
using PochtaSdk.Toolbox;
using Restub.DataContracts;
using Restub.Toolbox;

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
        // code + desc + sub-code — used in search_order method

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
        public ErrorCode? SubCode { get; set; }

        // status + message - used in api limits

        /// <summary>
        /// Статус запроса
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            Description.Coalesce(Message, SubCode?.GetDisplayName(), string.Empty);

        /// <inheritdoc/>
        public bool HasErrors() => !string.IsNullOrWhiteSpace(GetErrorMessage());
    }
}