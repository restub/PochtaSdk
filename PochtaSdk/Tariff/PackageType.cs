namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Package type.
    /// Код типа упаковки.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 3)
    /// </summary>
    public enum PackageType
    {
        BoxS = 10,
        BoxM = 20,
        BoxL = 30,
        BoxXL = 40,
        КоробкаS = 10,
        КоробкаМ = 20,
        КоробкаL = 30,
        КоробкаХL = 40,

        PlasticBagS = 11,
        PlasticBagM = 21,
        PlasticBagL = 31,
        PlasticBagXL = 41,
        ПакетПолиэтиленовыйS = 11,
        ПакетПолиэтиленовыйМ = 21,
        ПакетПолиэтиленовыйL = 31,
        ПакетПолиэтиленовыйХL = 41,

        BubbleWrapEnvelopeS = 12,
        BubbleWrapEnvelopeM = 22,
        КонвертСВоздушноПузырчатойПленкойS = 12,
        КонвертСВоздушноПузырчатойПленкойМ = 22,

        NonStandardPackage = 99,
        НестандартнаяУпаковка = 99,
    }
}
