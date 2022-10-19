using System.Linq;
using PochtaSdk.Otpravka;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru Otpravka API client. REST API methods related to shipping orders.
    /// https://otpravka.pochta.ru/specification
    /// </summary>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Create orders.
        /// https://otpravka.pochta.ru/specification#/orders-creating_order
        /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
        /// </summary>
        /// <returns>Order information.</returns>
        public OrderResponse CreateOrders(params Order[] orders)
        {
            var result = Put<OrderResponse>("2.0/user/backlog", orders);
            if (result != null)
            {
                // backward compatibility with v1.0
                var createdOrders = result.Orders ?? Enumerable.Empty<OrderShortInfo>();
                result.ResultIDs = createdOrders.Select(o => o.ResultID).ToArray();
            }

            return result;
        }

        /// <summary>
        /// Delete orders.
        /// https://otpravka.pochta.ru/specification#/orders-delete_new_order
        /// </summary>
        /// <param name="orderIds">Order identities to delete.</param>
        /// <returns>Deleted order identities.</returns>
        public OrderResponse DeleteOrders(params long[] orderIds) =>
            Delete<OrderResponse>("1.0/backlog", orderIds);

        /// <summary>
        /// Get order by identity.
        /// https://otpravka.pochta.ru/specification#/orders-search_order_byid
        /// </summary>
        /// <param name="orderId">Order identity.</param>
        /// <returns>Order details.</returns>
        public OrderInfo GetOrder(long orderId) =>
            Get<OrderInfo>("/1.0/backlog/{id}", r => r.AddUrlSegment("id", orderId));
    }
}
