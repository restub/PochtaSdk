using System;
using PochtaSdk.Otpravka;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to batch archive.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Search archived batches.
        /// Возвращает партии из архива.
        /// https://otpravka.pochta.ru/specification#/archive-search_batches
        /// </summary>
        /// <returns>Archived batches.</returns>
        public Batch[] GetArchivedBatches() =>
            Get<Batch[]>("1.0/archive");

        /// <summary>
        /// Archive batches.
        /// Помещает партии в архив.
        /// https://otpravka.pochta.ru/specification#/archive-batch_to_archive
        /// </summary>
        /// <param name="batchNames">Batch names (numbers) to archive.</param>
        /// <returns>Archived batches.</returns>
        public BatchNameErrorCode[] ArchiveBatches(params string[] batchNames) =>
            Put<BatchNameErrorCode[]>("1.0/archive", batchNames);

        /// <summary>
        /// Return batches from archive.
        /// Возвращает партии из архива.
        /// https://otpravka.pochta.ru/specification#/archive-revert_batch
        /// </summary>
        /// <param name="batchNames">Batch names (numbers) to archive.</param>
        /// <returns>Archived batches.</returns>
        public BatchNameErrorCode[] UnarchiveBatches(params string[] batchNames) =>
            Post<BatchNameErrorCode[]>("1.0/archive/revert", batchNames);
    }
}
