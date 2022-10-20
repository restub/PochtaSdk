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
        /// </summary>
        /// <param name="orderIds">Order identities.</param>
        /// <returns>Created batch.</returns>
        public BatchResponse CreateBatch(params long[] orderIds) => CreateBatch(new BatchRequest
        {
            OrderIDs = orderIds
        });

        /// <summary>
        /// Creates shipping order batch.
        /// </summary>
        /// <param name="request">Batch creation request.</param>
        /// <returns>Created batch.</returns>
        public BatchResponse CreateBatch(BatchRequest request) =>
            Post<BatchResponse>("1.0/user/shipment", request.OrderIDs, r => r
                .AddQueryString(request));

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
    }
}
