namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Group tariffication mode.
    /// Тарификация групп отправлений по общему весу.
    /// https://tariff.pochta.ru/post-calculator-api.pdf
    /// </summary>
    public enum GroupTariffication
    {
        StandalonePackage = 0,
        ОтдельноеОтправление = 0,

        PackageWithinGroup = 1,
        ОтправлениеВСоставеГруппы = 1,

        Group = 2,
        Группа = 2,
    }
}
