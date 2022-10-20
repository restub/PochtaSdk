using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error.
    /// Ошибка.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class Error
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
    }
}