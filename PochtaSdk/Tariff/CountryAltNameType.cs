#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Country alternative name types.
    /// Типы альтернативных имен стран.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.6)
    /// </summary>
    public enum CountryAltNameType
    {
        RussianSynonym = 1,
        РусскоязычныйСиноним = 1,

        Alpha2symbols = 2,
        КодАльфа2символа = 2,

        Alpha3symbols = 3,
        КодАльфа3символа = 3,

        EnglishName = 4,
        АнглийскоеНазвание = 4,

        FrenchName = 5,
        ФранцузскоеНазвание = 5,
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
