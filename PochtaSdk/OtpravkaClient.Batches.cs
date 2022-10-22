using System;
using PochtaSdk.Otpravka;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to batches.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Creates shipping order batch.
        /// Создание партии из N заказов.
        /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
        /// </summary>
        /// <param name="orderIds">Order identities.</param>
        /// <returns>Created batch.</returns>
        public BatchResponse CreateBatch(params long[] orderIds) => CreateBatch(new BatchRequest
        {
            OrderIDs = orderIds
        });

        /// <summary>
        /// Creates shipping order batch.
        /// Создание партии из N заказов.
        /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
        /// </summary>
        /// <param name="request">Batch creation request.</param>
        /// <returns>Created batch.</returns>
        public BatchResponse CreateBatch(BatchRequest request) =>
            Post<BatchResponse>("1.0/user/shipment", request.OrderIDs, r => r
                .AddQueryString(request));

        /// <summary>
        /// Get batch orders.
        /// Запрос данных о заказах в партии.
        /// https://otpravka.pochta.ru/specification#/batches-get_info_about_orders_in_batch
        /// </summary>
        /// <param name="batchName">Batch creation request.</param>
        /// <returns>Created batch.</returns>
        public OrderInfo[] GetBatchOrders(string batchName) =>
            GetBatchOrders(new BatchOrdersRequest(batchName));

        /// <summary>
        /// Get batch orders.
        /// Запрос данных о заказах в партии.
        /// https://otpravka.pochta.ru/specification#/batches-get_info_about_orders_in_batch
        /// </summary>
        /// <param name="request">Batch orders request.</param>
        /// <returns>Created batch.</returns>
        public OrderInfo[] GetBatchOrders(BatchOrdersRequest request) =>
            Get<OrderInfo[]>("1.0/batch/{name}/shipment", r => r
                .AddUrlSegment("name", request.BatchName)
                .AddQueryString(request));

        /// <summary>
        /// Returns shipping order batch by its name (number).
        /// Поиск партии по наименованию.
        /// https://otpravka.pochta.ru/specification#/batches-find_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <returns>Batch with the given name.</returns>
        public Batch GetBatch(string batchName) =>
            Get<Batch>("1.0/batch/{name}", r => r.AddUrlSegment("name", batchName));

        /// <summary>
        /// Search shipping order batches by mail type, mail category, etc.
        /// Поиск партии по типам, категориям отправлений и пр.
        /// https://otpravka.pochta.ru/specification#/batches-search_all_batches
        /// </summary>
        /// <param name="mailType">Mail type.</param>
        /// <param name="mailCategory">Mail category.</param>
        /// <returns>Batches mathing the search criteria.</returns>
        public Batch[] SearchBatches(MailType? mailType = null, MailCategory? mailCategory = null) =>
            SearchBatches(new BatchSearchRequest
            {
                MailCategory = mailCategory,
                MailType = mailType
            });

        /// <summary>
        /// Search shipping order batches by mail type, mail category, etc.
        /// Поиск партии по типам, категориям отправлений и пр.
        /// https://otpravka.pochta.ru/specification#/batches-search_all_batches
        /// </summary>
        /// <param name="request">Batch search request.</param>
        /// <returns>Batches mathing the search criteria.</returns>
        public Batch[] SearchBatches(BatchSearchRequest request) =>
            Get<Batch[]>("1.0/batch", r =>
            {
                r.AddQueryString(request);
            });

        /// <summary>
        /// Add orders to batch.
        /// Перенос заказов в партию. 
        /// Переносит подготовленные заказы в указанную партию. 
        /// Если часть заказов не может быть помещена в партию (тип и категория партии 
        /// не соответствует типу и категории заказа) - возвращается json объект с указанием 
        /// индекса заказа в переданном массиве и типом ошибки, остальные заказы помещаются 
        /// в указанную партию. Каждому перенесенному заказу автоматически присваивается ШПИ.
        /// https://otpravka.pochta.ru/specification#/batches-move_orders_to_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="orderIds">Order identities to add.</param>
        /// <returns>Order identities added to the batch.</returns>
        public BatchResponse AddToBatch(string batchName, params long[] orderIds) =>
            Post<BatchResponse>("1.0/batch/{name}/shipment", orderIds, r => r.AddUrlSegment("name", batchName));

        /// <summary>
        /// Return shipment orders to backlog state.
        /// Возврат заказов в «Новые». 
        /// Метод переводит заказы из партии в раздел Новые.
        /// Партия должна быть в статусе CREATED.
        /// https://otpravka.pochta.ru/specification#/orders-shipment_to_backlog
        /// </summary>
        /// <param name="orderIds">Order identities to delete.</param>
        /// <returns>Deleted order identities.</returns>
        public OrderResponseBase RemoveFromBatch(params long[] orderIds) =>
            Post<OrderResponseBase>("1.0/user/backlog", orderIds);

        /// <summary>
        /// Changes batch sending date.
        /// Изменение дня отправки в почтовое отделение.
        /// https://otpravka.pochta.ru/specification#/batches-sending_date
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="newDate">New date.</param>
        /// <returns>Created batch.</returns>
        public BatchDateResponse ChangeBatchDate(string batchName, DateTime newDate) =>
            Post<BatchDateResponse>("1.0/batch/{name}/sending/{year}/{month}/{dayOfMonth}", null, r => r
                .AddUrlSegment("name", batchName)
                .AddUrlSegment("year", newDate.Year)
                .AddUrlSegment("month", newDate.Month)
                .AddUrlSegment("dayOfMonth", newDate.Day));

        /// <summary>
        /// Delete batch (not supported).
        /// Удаление партии (не поддерживается).
        /// https://otpravka.pochta.ru/specification#/batches-undocumented
        /// </summary>
        /// <param name="batchName">Batch name (number) to delete.</param>
        /// <returns>Deleted batch names.</returns>
        private BatchDeletionResponse DeleteBatch(string batchName) =>
            Delete<BatchDeletionResponse>("1.0/batch/{name}", null, r => r.AddUrlSegment("name", batchName));
    }
}
