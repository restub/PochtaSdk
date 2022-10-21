using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch orders request.
    /// Запрос метода получения списка заказов партии.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class BatchOrdersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOrdersRequest"/> class.
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        public BatchOrdersRequest(string batchName) => BatchName = batchName;

        /// <summary>
        /// Наименование партии
        /// </summary>
        [IgnoreDataMember]
        public string BatchName { get; set; }

        /// <summary>
        /// Количество записей на странице (Опционально)
        /// </summary>
        [DataMember(Name = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// Номер страницы (0..N) (Опционально)
        /// </summary>
        [DataMember(Name = "page")]
        public int? Page { get; set; }

        /// <summary>
        /// Критерии сортировки в формате: asc(по возрастанию) или desc (по убыванию).
        /// По умолчанию порядок сортировки по возрастанию (Опционально)
        /// </summary>
        [DataMember(Name = "sort")]
        public string Sort { get; set; }
    }
}
