namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Payment types.
    /// Способы оплаты.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (page 10)
    /// </summary>
    public enum PaymentType
    {
        Cash = 1,
        Наличные = 1,

        Card = 2,
        Карта = 2,
    }
}
