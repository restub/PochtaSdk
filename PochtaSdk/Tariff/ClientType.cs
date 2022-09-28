namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Client types.
    /// Типы клиентов.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (page 9)
    /// </summary>
    public enum ClientType
    {
        PrivatePerson = 1,
        ФизическоеЛицо = 1,

        LegalBody = 2,
        ЮридическоеЛицо = 2,

        PreferentialCategory = 3,
        ЛьготныеКатегории = 3,
    }
}
