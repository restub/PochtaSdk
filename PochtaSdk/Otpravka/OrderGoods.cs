using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping order goods contents.
    /// Товарное вложение РПО.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class OrderGoods
    {
        /// <summary>
        /// Список вложений
        /// </summary>
        [DataMember(Name = "items")]
        public List<OrderGoodsItem> Items { get; set; }
    }
}
