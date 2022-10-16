using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order goods item type.
    /// Тип вложения, товар или услуга.
    /// https://otpravka.pochta.ru/specification#/enums-goods-type
    /// </summary>
    [DataContract]
    public enum OrderGoodsItemType
    {
        /// <summary>
        /// Goods
        /// Товар
        /// </summary>
        [EnumMember(Value = "GOODS")]
        Goods,

        /// <summary>
        /// Service
        /// Услуга
        /// </summary>
        [EnumMember(Value = "SERVICE")]
        Service,
    }
}
