namespace PochtaSdk.Tariff
{
    /// <summary>
    /// International product types.
    /// Коды международных продуктов.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 15)
    /// </summary>
    public enum InternationalProductType
    {
        NRM = 1,
        RDnR = 2,
        RDnRAir = 3,
        cPacket = 4,
        RM = 5,
        RMH = 6,
        SRM = 7,
        RDC = 8,
        Parcel = 9,
        SmParcel = 10,
        PH = 11,
    }
}
