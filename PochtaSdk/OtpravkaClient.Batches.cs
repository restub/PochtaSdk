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
            Post<BatchResponse>("1.0/user/shipment", request.OrderIDs, r =>
            {
                r.AddQueryString(request);
                if (request.SendingDate.HasValue)
                {
                    r.AddQueryParameter("sending-date",
                        request.SendingDate.Value.ToString("yyyy-MM-dd"));
                }
            });

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
        /// Add existing orders to batch.
        /// Перенос существующих заказов в партию. 
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
            AddToBatch(batchName, null, orderIds);

        /// <summary>
        /// Add existing orders to batch.
        /// Перенос существующих заказов в партию. 
        /// Переносит подготовленные заказы в указанную партию. 
        /// Если часть заказов не может быть помещена в партию (тип и категория партии 
        /// не соответствует типу и категории заказа) - возвращается json объект с указанием 
        /// индекса заказа в переданном массиве и типом ошибки, остальные заказы помещаются 
        /// в указанную партию. Каждому перенесенному заказу автоматически присваивается ШПИ.
        /// https://otpravka.pochta.ru/specification#/batches-move_orders_to_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="orderIds">Order identities to add.</param>
        /// <returns>Order identities added to the batch.</returns>
        public BatchResponse AddToBatch(string batchName, string groupName, params long[] orderIds) =>
            Post<BatchResponse>("1.0/batch/{name}/shipment", orderIds, r =>
            {
                r.AddUrlSegment("name", batchName);
                if (!string.IsNullOrWhiteSpace(groupName))
                { 
                    r.AddQueryParameter("group-name", groupName);
                }
            });

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
        /// Add orders to batch.
        /// Добавление заказов в партию. 
        /// Создает массив заказов и помещает непосредственно в партию.
        /// Автоматически рассчитывает и проставляет плату за пересылку. 
        /// Каждому заказу автоматически присваивается ШПИ.
        /// https://otpravka.pochta.ru/specification#/batches-add_orders_to_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="orders">Orders to create.</param>
        /// <returns>Order identities added to the batch.</returns>
        public OrderResponseBase AddToBatch(string batchName, params Order[] orders) =>
            Put<OrderResponseBase>("1.0/batch/{name}/shipment", orders, r => r
                .AddUrlSegment("name", batchName));

        /// <summary>
        /// Get batch orders.
        /// Запрос данных о заказах в партии.
        /// https://otpravka.pochta.ru/specification#/batches-get_info_about_orders_in_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
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
        /// Search batched orders by barcode.
        /// Поиск заказа в партиях по штрих-коду ШПИ.
        /// https://otpravka.pochta.ru/specification#/batches-find_orders_with_barcode
        /// </summary>
        /// <param name="query">Search query (shipment barcode).</param>
        /// <returns>Order details.</returns>
        public OrderInfo[] SearchBatchOrders(string query) =>
            Get<OrderInfo[]>("1.0/shipment/search", r => r.AddQueryParameter("query", query));

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
        /// Remove orders from shipment batch and return to backlog state.
        /// Удаление заказов из партии и возврат их в состояние «Новые». 
        /// Метод переводит заказы из партии в раздел Новые.
        /// Партия должна быть в статусе CREATED.
        /// https://otpravka.pochta.ru/specification#/orders-shipment_to_backlog
        /// </summary>
        /// <param name="orderIds">Order identities to remove from batch.</param>
        /// <returns>Removed order identities.</returns>
        public OrderResponseBase RemoveFromBatch(params long[] orderIds) =>
            Post<OrderResponseBase>("1.0/user/backlog", orderIds);

        /// <summary>
        /// Deletes orders from shipment batch.
        /// Удаление заказов, находящихся в составе партии.
        /// https://otpravka.pochta.ru/specification#/batches-delete_order_from_batch
        /// </summary>
        /// <param name="orderIds">Order identities to delete.</param>
        /// <returns>Deleted order identities.</returns>
        public BatchResponse DeleteFromBatch(params long[] orderIds) =>
            Delete<BatchResponse>("1.0/shipment", orderIds);

        /// <summary>
        /// Get batched order by identity.
        /// Поиск заказа в составе партии по идентификатору.
        /// https://otpravka.pochta.ru/specification#/batches-find_order_by_id
        /// </summary>
        /// <remarks>
        /// Doesn't return unbatched orders.
        /// Этот метод не возвращает заказы, не находящиеся в составе партии.
        /// </remarks>
        /// <param name="orderId">Order identity.</param>
        /// <returns>Order details.</returns>
        public OrderInfo GetBatchOrder(long orderId) =>
            Get<OrderInfo>("1.0/shipment/{id}", r => r.AddUrlSegment("id", orderId));

        /// <summary>
        /// Search batched orders by group name.
        /// Поиск заказов в партии по идентификатору группы
        /// https://otpravka.pochta.ru/specification#/batches-find_orders_by_group_name
        /// </summary>
        /// <remarks>
        /// Doesn't return unbatched orders.
        /// Этот метод не возвращает заказы, не находящиеся в составе партии.
        /// </remarks>
        /// <param name="groupName">Group name.</param>
        /// <returns>Order details.</returns>
        public OrderInfo[] SearchBatchOrdersByGroupName(string groupName) =>
            Get<OrderInfo[]>("1.0/shipment/by-group-name/{group-name}", r => r
                .AddUrlSegment("group-name", groupName));

        /// <summary>
        /// Checks in the given batch for sending.
        /// Finalizes the batch. Sends F103 electronic form for registration.
        /// Регистрирует партию для приема сотрудниками ОПС.
        /// Финализирует партию. Отправляет электронную форму Ф103 для регистрации.
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="useOnlineBalance">Use online balance.</param>
        /// <returns><see cref="BatchDateResponse"/> instance.</returns>
        public BatchDateResponse CheckinBatch(string batchName, bool? useOnlineBalance = null) =>
            Post<BatchDateResponse>("1.0/batch/{name}/checkin", null, r =>
            {
                r.AddUrlSegment("name", batchName);
                if (useOnlineBalance.HasValue)
                {
                    r.AddQueryParameter("useOnlineBalance",
                        useOnlineBalance.Value.ToString().ToLower());
                }
            });
    }
}
