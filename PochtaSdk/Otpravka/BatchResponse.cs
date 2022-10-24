using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch creation response.
    /// Ответ метода создания партий.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class BatchResponse : IHasErrors
    {
        /// <summary>
        /// Партии
        /// </summary>
        [DataMember(Name = "batches")]
        public Batch[] Batches { get; set; }

        /// <summary>
        /// Ошибки
        /// </summary>
        [DataMember(Name = "errors")]
        public ErrorWithCode[] Errors { get; set; }

        /// <summary>
        /// Коды заказов
        /// </summary>
        [DataMember(Name = "result-ids")]
        public long[] ResultIDs { get; set; }

        /// <summary>
        /// Возвращает true, если в списке есть элементы, обработанные без ошибки.
        /// </summary>
        protected virtual bool HasOrders => ResultIDs != null && ResultIDs.Any();

        /// <inheritdoc/>
        public bool HasErrors() => !HasOrders && Errors != null && Errors.Any();

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            string.Join(". ", Errors
                .Select(e => (e.Description + string.Empty)
                    .Trim(". \r\n\v".ToCharArray())));
    }
}
