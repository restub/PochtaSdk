using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch name and error code.
    /// Имя (номер) партии и код ошибки.
    /// https://otpravka.pochta.ru/specification#/archive-batch_to_archive
    /// https://otpravka.pochta.ru/specification#/archive-revert_batch
    /// </summary>
    [DataContract]
    public class BatchNameErrorCode
    {
        /// <summary>
        /// Наименование партии
        /// </summary>
        [DataMember(Name = "batch-name")]
        public string BatchName { get; set; }

        /// <summary>
        /// Error code
        /// Код ошибки
        /// </summary>
        [DataMember(Name = "error-code")]
        public ErrorCode? ErrorCode { get; set; }
    }
}
