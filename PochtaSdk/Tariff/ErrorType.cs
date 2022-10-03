namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Error types.
    /// Типы ошибок.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.2)
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// Internal service error.
        /// Внутренняя системная ошибка сервиса.
        /// </summary>
        InternalError = 0,

        /// <summary>
        /// Tariff calculation error.
        /// Ошибка, произошедшая при расчете тарифа.
        /// </summary>
        TariffError = 1,

        /// <summary>
        /// Delivery terms calculation error.
        /// Ошибка, произошедшая при расчете тарифа.
        /// </summary>
        DeliveryTermError = 2,

        /// <summary>
        /// Generic service calculation error, such as icorrect input format.
        /// Ошибка, не относящаяся к конкретному расчету
        /// (например, неверный формат входного запроса).
        /// </summary>
        GenericError = 3,
    }
}
