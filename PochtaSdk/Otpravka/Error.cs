using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error.
    /// Ошибка.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/orders-editing_order
    /// </summary>
    [DataContract]
    public class Error : IHasErrors
    {
        /// <summary>
        /// Код ошибки
        /// </summary>
        [DataMember(Name = "error-code")]
        public ErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Список текстов и кодов ошибок
        /// </summary>
        [DataMember(Name = "error-codes")]
        public ErrorWithCode[] ErrorCodes { get; set; }

        /// <summary>
        /// Порядковый номер элемента, к которому относится ошибка
        /// </summary>
        [DataMember(Name = "position")]
        public int Position { get; set; }

        public string GetErrorMessage() =>
            string.Join(". ", (ErrorCodes ?? Enumerable.Empty<ErrorWithCode>())
                .Select(e => (e.Description + string.Empty).Trim(' ', '.', '\r', '\n')));

        public bool HasErrors() => ErrorCode != null || (ErrorCodes != null && ErrorCodes.Any());
    }
}