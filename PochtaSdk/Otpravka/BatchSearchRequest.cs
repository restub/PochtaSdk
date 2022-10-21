using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch search request.
    /// Запрос метода поиска партий.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class BatchSearchRequest
    {
        /// <summary>
        /// Тип отправления (Опционально)
        /// </summary>
        [DataMember(Name = "mailType")]
        public MailType? MailType { get; set; }

        /// <summary>
        /// Категория отправления (Опционально)
        /// </summary>
        [DataMember(Name = "mailCategory")]
        public MailCategory? MailCategory { get; set; }

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
