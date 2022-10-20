using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch date changing response.
    /// Ответ метода изменения даты партий.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class BatchDateResponse
    {
        /// <summary>
        /// Error code
        /// Код ошибки
        /// </summary>
        [DataMember(Name = "error-code")]
        public ErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Отослана ли электронная версия ф103/ф103п в ОПС?
        /// </summary>
        [DataMember(Name = "f103-sent")]
        public bool F103Sent { get; set; }
    }
}
