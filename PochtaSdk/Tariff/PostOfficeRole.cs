namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Post office roles.
    /// Участие почтового отделения в расчете тарифа.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.5)
    /// </summary>
    public enum PostOfficeRole
    {
        Reception = 1,
        МестоПриема = 1,

        Destination = 2,
        МестоНазначения = 2,

        OutgoingInternationalExchange = 3,
        МестоОбменаИсходящегоОтправления = 3,

        IncomingInternationalExchange = 4,
        МестоОбменаВходящегоОтправления = 4,

        OverloadLocation = 5,
        МестоПерегрузки = 4,

        Other = 0,
        Прочее = 0,
    }
}
