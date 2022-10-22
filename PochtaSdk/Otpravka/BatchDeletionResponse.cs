using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch deletion response.
    /// Ответ метода удаления партий.
    /// https://otpravka.pochta.ru/specification#/batches-undocumented
    /// </summary>
    [DataContract]
    internal class BatchDeletionResponse
    {
        /// <summary>
        /// Batch names (numbers)
        /// Названия (номера) партий
        /// </summary>
        [DataMember(Name = "batchNames")]
        public string[] BatchNames { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation was successful
        /// Успешно ли выполнена операция
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }
    }
}
