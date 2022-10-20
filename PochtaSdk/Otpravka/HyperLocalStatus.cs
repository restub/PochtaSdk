using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Hyper local statuses.
    /// Статус партии по гиперлокальной доставке.
    /// https://otpravka.pochta.ru/specification#/enums-batch-hyper-local-status
    /// </summary>
    [DataContract]
    public enum HyperLocalStatus
    {
        /// <summary>
        /// Заявки в обработке
        /// </summary>
        [EnumMember(Value = "BATCH_PROCESSING")]
        BatchProcessing,

        /// <summary>
        /// Заявки исполнены
        /// </summary>
        [EnumMember(Value = "BATCH_EXECUTE")]
        BatchExecuted,

        /// <summary>
        /// Заявки не исполнены
        /// </summary>
        [EnumMember(Value = "BATCH_NOT_EXECUTE")]
        BatchNotExecuted,

        /// <summary>
        /// Заявки исполнены частично
        /// </summary>
        [EnumMember(Value = "BATCH_EXECUTE_PARTIALLY")]
        BatchExecutedPartially,
    }
}