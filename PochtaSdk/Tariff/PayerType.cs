namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Payer types.
    /// Плательщики.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (page 10)
    /// </summary>
    public enum PayerType
    {
        Sender = 1,
        Отправитель = 1,

        Receiver = 2,
        Получатель = 2,
    }
}
