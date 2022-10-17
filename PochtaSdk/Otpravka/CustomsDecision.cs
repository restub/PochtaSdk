using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Customs decision.
    /// Решение таможенного органа.
    /// https://otpravka.pochta.ru/specification#/orders-search_order_byid
    /// </summary>
    [DataContract]
    public enum CustomsDecision
    {
        /// <summary>
        /// Rejection
        /// Отказ
        /// </summary>
        [EnumMember(Value = "REJECTION")]
        Rejection,

        /// <summary>
        /// Release without customs duty
        /// Выпуск без уплаты таможенной пошлины
        /// </summary>
        [EnumMember(Value = "RELEASE_WO_CUSTOMS_DUTY")]
        ReleaseWithoutCustomsDuty,

        /// <summary>
        /// Customs duty required
        /// Требуется уплата таможенной пошлины
        /// </summary>
        [EnumMember(Value = "CUSTOMS_DUTY_REQUIRED")]
        CustomsDutyRequired,

        /// <summary>
        /// Customs control required
        /// Требуется таможенный досмотр
        /// </summary>
        [EnumMember(Value = "CUSTOMS_CONTROL_REQUIRED")]
        CustomsControlRequired,

        /// <summary>
        /// Reserve
        /// Резерв
        /// </summary>
        [EnumMember(Value = "RESERVE")]
        Reserve,

        /// <summary>
        /// Release suspended
        /// Выпуск задержан
        /// </summary>
        [EnumMember(Value = "RELEASE_SUSPENDED")]
        ReleaseSuspended,

        /// <summary>
        /// Release period prolonged
        /// Время выпуска продлено
        /// </summary>
        [EnumMember(Value = "RELEASE_PERIOD_PROLONGED")]
        ReleasePeriodProlonged,

        /// <summary>
        /// Release with customs duty paid
        /// Выпуск с уплатой таможенной пошлины
        /// </summary>
        [EnumMember(Value = "RELEASE_CUSTOMS_DUTY_PAID")]
        ReleaseCustomsDutyPaid,

        /// <summary>
        /// Automatic release returned goods
        /// Автовыпуск возвращенных товаров
        /// </summary>
        [EnumMember(Value = "AUTO_RELEASE_RETURN_GOODS")]
        AutoReleaseReturnGoods,

        /// <summary>
        /// Release returned goods
        /// Выпуск возвращенных товаров
        /// </summary>
        [EnumMember(Value = "RELEASE_RETURN_GOODS")]
        ReleaseReturnGoods,

        /// <summary>
        /// Rejection of the automatic release
        /// Отказ в автоматическом выпуске
        /// </summary>
        [EnumMember(Value = "REJECTION_AUTO_RELEASE")]
        RejectionAutoRelease,

        /// <summary>
        /// Departure allowed
        /// Отбытие разрешено
        /// </summary>
        [EnumMember(Value = "DEPARTURE_ALLOWED")]
        DepartureAllowed,

        /// <summary>
        /// Departure denied
        /// Отбытие запрещено
        /// </summary>
        [EnumMember(Value = "DEPARTURE_DENIED")]
        DepartureDenied,
    }
}
