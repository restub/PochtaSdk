using System;
using PochtaSdk.Otpravka;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru Otpravka API client. REST API methods related to batches.
    /// https://otpravka.pochta.ru/specification
    /// </summary>
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
        /// Returns shipping order batch by its name (number).
        /// Поиск партии по наименованию.
        /// https://otpravka.pochta.ru/specification#/batches-find_batch
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <returns>Batch with the given name.</returns>
        public Batch GetBatch(string batchName) =>
            Get<Batch>("1.0/batch/{name}", r => r.AddUrlSegment("name", batchName));

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
    }
}
