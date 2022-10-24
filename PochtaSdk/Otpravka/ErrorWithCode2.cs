using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Error with code #2.
    /// Код и описание ошибки #2.
    /// Такие ошибки возвращают методы, работающие с партиями (префиксы error- добавляются к названиям свойств).
    /// https://otpravka.pochta.ru/specification#/batches-move_orders_to_batch
    /// </summary>
    [DataContract]
    public class ErrorWithCode2
    {
        /// <summary>
        /// Код ошибки.
        /// </summary>
        [DataMember(Name = "error-code")]
        public ErrorCode Code { get; set; }

        [DataMember(Name = "error-description")]
        public string Description { get; set; }

        [DataMember(Name = "error-details")]
        public string Details { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }
    }
}