namespace PochtaSdk.Tariff
{
    /// <summary>
    /// International tariff types.
    /// Коды международных тарифов.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 16)
    /// </summary>
    public enum InternationalTariffType
    {
        BranchRate = 1,
        ClientsideLogisticsRate = 2,
        DoRate = 3,
        ClientsRate = 4,
        IntercompanyTdRate = 5,
        TdRate = 6,
        IntrasystemRate = 7,
        ServiceProviderLogisticsRate = 8,
    }
}
