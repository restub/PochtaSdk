using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order creation/deletion response (API v2.0).
    /// Ответ метода создания или удаления заказов (API v2.0).
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/orders-delete_new_order
    /// </summary>
    [DataContract]
    public class OrderResponse : OrderResponseBase
    {
        [DataMember(Name = "orders")] // v2.0
        public OrderShortInfo[] Orders { get; set; }

        protected override bool HasOrders =>
            base.HasOrders || (Orders != null && Orders.Any());
    }
}
