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
        [DataMember(Name = "error-code")]
        public ErrorCode? ErrorCode { get; set; }

        [DataMember(Name = "error-codes")]
        public ErrorWithCode[] ErrorCodes { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }
    }
}