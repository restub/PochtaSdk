namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Avia delivery preference.
    /// Предпочтение воздушной доставки.
    /// https://tariff.pochta.ru/post-calculator-api.pdf
    /// </summary>
    public enum AviaDeliveryPreference
    {
        NoAviaDelivery = 0,
        НаземнаяДоставка = 0,

        PreferAviaDelivery = 1,
        ПредпочтительноВоздушнаяДоставка = 1,

        AviaDeliveryOnly = 2,
        СтрогоВоздушнаяДоставка = 2,
    }
}
