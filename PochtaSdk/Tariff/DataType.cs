namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Data types.
    /// Типы данных.
    /// Сериализуются в виде чисел, поэтому атрибут DataContract не применяется.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.6)
    /// </summary>
    public enum DataType
    {
        Integer = 1,
        String = 2,
        Decimal = 3,
        Date = 4,
        Boolean = 5, // логический [0, 1]
        Money = 13, // сумма в копейках
        Month = 17, // месяц [1..12]
        Weight = 29, // вес в граммах
        PostCode = 33, // индекс
        Dictionary = 41, // справочник
        Array = 52, // массив чисел
    }
}
