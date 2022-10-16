using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error with code.
    /// Код и описание ошибки.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class ErrorWithCode
    {
        /// <summary>
        /// Код ошибки.
        /// </summary>
        [DataMember(Name = "code")]
        public ErrorCode Code { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "details")]
        public string Details { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }
    }
}