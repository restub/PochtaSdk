using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Courier order statuses.
    /// Статусы заявки на вызов курьера.
    /// https://otpravka.pochta.ru/specification#/enums-courier-order-statuses
    /// </summary>
    [DataContract]
    public enum CourierOrderStatus
    {
        /// <summary>
        /// Заявка на вызов курьера не требуется
        /// </summary>
        [EnumMember(Value = "NOT_REQUIRED")]
        NotRequired,

        /// <summary>
        /// Разрешена подача заявки на вызов курьера
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        Available,

        /// <summary>
        /// Пользователь отказался от подачи заявки на вызок курьера
        /// </summary>
        [EnumMember(Value = "REFUSED_BY_USER")]
        RefusedByUser,

        /// <summary>
        /// Заявка на вызов курьера в процессе
        /// </summary>
        [EnumMember(Value = "ORDER_IN_PROGRESS")]
        OrderInProgress,

        /// <summary>
        /// Заявка на вызов курьера отклонена на стороне КЦ
        /// </summary>
        [EnumMember(Value = "ORDER_REJECTED")]
        OrderRejected,

        /// <summary>
        /// Попытка отправки не удалась
        /// </summary>
        [EnumMember(Value = "ATTEMPT_FAILED")]
        AttemptFailed,

        /// <summary>
        /// Заявка завершена
        /// </summary>
        [EnumMember(Value = "ORDER_COMPLETED")]
        OrderCompleted,

        /// <summary>
        /// Самостоятельная доставка
        /// </summary>
        [EnumMember(Value = "MANUAL_DELIVERY")]
        ManualDelivery,
    }
}
