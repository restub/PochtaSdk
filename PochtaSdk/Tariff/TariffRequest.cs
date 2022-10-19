using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Pochta.ru tariff calculation request.
    /// </summary>
    [DataContract]
    public class TariffRequest
    {
        /// <summary>
        /// Tariff calculation object.
        /// Объект расчета тарифа.
        /// </summary>
        [DataMember(Name = "object")]
        public ObjectType ObjectType { get; set; } = ObjectType.LetterRegular;

        /// <summary>
        /// From postal code.
        /// Почтовый индекс места отправления.
        /// </summary>
        [DataMember(Name = "from")]
        public int FromPostCode { get; set; }

        /// <summary>
        /// To postal code.
        /// Почтовый индекс места назначения.
        /// </summary>
        [DataMember(Name = "to")]
        public int ToPostCode { get; set; }

        /// <summary>
        /// Return postal code.
        /// Почтовый индекс места возврата.
        /// </summary>
        [DataMember(Name = "return")]
        public int? ReturnPostCode { get; set; }

        /// <summary>
        /// Destination country for outgoing international deliveries.
        /// Страна назначения для международных исходящих отправлений.
        /// </summary>
        [DataMember(Name = "country-to")]
        public OksmCountryCode? CountryTo { get; set; }

        /// <summary>
        /// Source country for outgoing international deliveries.
        /// Страна приема для международных входящих отправлений.
        /// </summary>
        [DataMember(Name = "country-from")]
        public OksmCountryCode? CountryFrom { get; set; }

        /// <summary>
        /// Region code for regional services.
        /// Код региона, для тарификации региональных услуг.
        /// </summary>
        [DataMember(Name = "region")]
        public int? Region { get; set; }

        /// <summary>
        /// Weight, grams.
        /// Вес, в граммах.
        /// </summary>
        [DataMember(Name = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Weight of a delivery lot, grams.
        /// Вес партии отправления, в граммах.
        /// </summary>
        [DataMember(Name = "weightall")]
        public int? WeightAll { get; set; }

        /// <summary>
        /// Average weight of a shipment, grams.
        /// Средний вес отправления, в граммах.
        /// </summary>
        [DataMember(Name = "aweight")]
        public int? WeightAvg { get; set; }

        /// <summary>
        /// Declared value, cents.
        /// Сумма объявленной ценности, в копейках.
        /// </summary>
        [DataMember(Name = "sumoc")]
        public int? SumOc { get; set; }

        /// <summary>
        /// Cash on delivery, cents.
        /// Сумма наложенного платежа, в копейках.
        /// </summary>
        [DataMember(Name = "sumnp")]
        public int? SumNp { get; set; }

        /// <summary>
        /// Warranty amount, cents.
        /// Сумма гарантии отправления, в копейках.
        /// </summary>
        [DataMember(Name = "sumgs")]
        public int? SumGs { get; set; }

        /// <summary>
        /// Amount, cents.
        /// Сумма, в копейках.
        /// </summary>
        [DataMember(Name = "sum")]
        public int? Sum { get; set; }

        /// <summary>
        /// Payment amount or included amount, cents.
        /// Сумма платежа или вложения, в копейках.
        /// </summary>
        [DataMember(Name = "sumin")]
        public int? SumIn { get; set; }

        /// <summary>
        /// Monthly payment amount, cents.
        /// Объем платежей в месяц, в копейках.
        /// </summary>
        [DataMember(Name = "sum_month")]
        public int? SumMonth { get; set; }

        /// <summary>
        /// Insurance/subscription period for the corresponding
        /// insurance or subscription services, in months.
        /// Период в месяцах страхования/абонирования ячейки для
        /// соответствующих услуг страхования и абонирования ячейки.
        /// </summary>
        [DataMember(Name = "month")]
        public int? Month { get; set; }

        /// <summary>
        /// Package size, cm. Three integers delimited with "x": 100x50x25.
        /// Размер отправления в сантиметрах. Указывается как три целых числа,
        /// разделенные знаком “x”, например, 100x50x25.
        /// </summary>
        [DataMember(Name = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Quantity of units, words, days, etc.
        /// Количество: штук, слов, материалов, дней или размещений,
        /// в зависимости от объекта расчета.
        /// </summary>
        [DataMember(Name = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Package type.
        /// Код типа упаковки.
        /// </summary>
        [DataMember(Name = "pack")]
        public PackageType? PackageType { get; set; }

        /// <summary>
        /// Quantity of packages in the group.
        /// Количество отправлений в группе.
        /// Значение параметра зависит от объекта расчета.
        /// </summary>
        [DataMember(Name = "countinpack")]
        public int? CountInPack { get; set; }

        /// <summary>
        /// Contract number.
        /// Договор между корпоративным клиентом и АО «Почта России».
        /// </summary>
        [DataMember(Name = "dogovor")]
        public string Dogovor { get; set; }

        /// <summary>
        /// Avia delivery preference.
        /// Опция авиа-доставки.
        /// </summary>
        [DataMember(Name = "isavia")]
        public AviaDeliveryPreference IsAvia { get; set; }

        /// <summary>
        /// Additional services for tariff calculation.
        /// Указываются модификаторы расчета, т.е. коды
        /// дополнительных услуг или вариантов расчета.
        /// </summary>
        [DataMember(Name = "service")]
        public List<ServiceType> Services { get; set; } = new List<ServiceType>();

        /// <summary>
        /// Post mark code.
        /// Код суммы отметок внутренних и
        /// международных отправлений.
        /// </summary>
        [DataMember(Name = "postmark")]
        public int? PostMark { get; set; }

        /// <summary>
        /// Mail rank.
        /// Код разряда почтового отправления.
        /// </summary>
        [DataMember(Name = "mailrank")]
        public int? MailRank { get; set; }

        /// <summary>
        /// Mail type code.
        /// Вид отправления, согласно РТМ-2.
        /// </summary>
        [DataMember(Name = "mailtype")]
        public int? MailType { get; set; }

        /// <summary>
        /// Mail category code.
        /// Категория отправления, согласно РТМ-2.
        /// </summary>
        [DataMember(Name = "mailctg")]
        public int? MailCtg { get; set; }

        /// <summary>
        /// Direction category.
        /// Направление доставки отправления.
        /// </summary>
        [DataMember(Name = "directctg")]
        public DirectionCategory? DirectionCategory { get; set; }

        /// <summary>
        /// Generic parameter 1.
        /// Универсальный параметр 1.
        /// </summary>
        [DataMember(Name = "p1")]
        public int? P1 { get; set; }

        /// <summary>
        /// Generic parameter 2.
        /// Универсальный параметр 2.
        /// </summary>
        [DataMember(Name = "p2")]
        public int? P2 { get; set; }

        /// <summary>
        /// Generic parameter 3.
        /// Универсальный параметр 3.
        /// </summary>
        [DataMember(Name = "p3")]
        public int? P3 { get; set; }

        /// <summary>
        /// Generic parameter 4.
        /// Универсальный параметр 4.
        /// </summary>
        [DataMember(Name = "p4")]
        public int? P4 { get; set; }

        /// <summary>
        /// Generic parameter 5.
        /// Универсальный параметр 5.
        /// </summary>
        [DataMember(Name = "p5")]
        public int? P5 { get; set; }

        /// <summary>
        /// Request identifier, for tagging requests.
        /// Внешний идентификатор запроса.
        /// </summary>
        [DataMember(Name = "reqid")]
        public string ReqID { get; set; }

        /// <summary>
        /// Group tariffication mode.
        /// Признак тарификации группы отправлений по общему весу.
        /// </summary>
        [DataMember(Name = "group")]
        public GroupTariffication? Group { get; set; }

        /// <summary>
        /// Outgoing international shipping index.
        /// Индекс исходящего ММПО.
        /// </summary>
        [DataMember(Name = "export")]
        public int? ExportIndex { get; set; }

        /// <summary>
        /// Incoming international shipping index.
        /// Индекс входящего ММПО.
        /// </summary>
        [DataMember(Name = "import")]
        public int? ImportIndex { get; set; }

        /// <summary>
        /// Volume.
        /// Объём. Для некоторых продуктов или услуг.
        /// </summary>
        [DataMember(Name = "volume")]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Duration.
        /// Длительность. Для некоторых продуктов или услуг.
        /// </summary>
        [DataMember(Name = "duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        /// Domestic.
        /// Доместик.
        /// </summary>
        [DataMember(Name = "domestic")]
        public int? Domestic { get; set; }

        /// <summary>
        /// Payment type.
        /// Способ платежа.
        /// </summary>
        [DataMember(Name = "paytype")]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// Payer type.
        /// Кто плательщик.
        /// </summary>
        [DataMember(Name = "payer")]
        public PayerType? PayerType { get; set; }

        /// <summary>
        /// International product type.
        /// Международный продукт.
        /// </summary>
        [DataMember(Name = "int-product")]
        public InternationalProductType? IntProduct { get; set; }

        /// <summary>
        /// International tariff type.
        /// Международный тариф.
        /// </summary>
        [DataMember(Name = "int-type")]
        public InternationalTariffType? IntType { get; set; }

        /// <summary>
        /// International delivery channel.
        /// Международный канал доставки.
        /// </summary>
        [DataMember(Name = "channel")]
        public InternationalDeliveryChannel? Channel { get; set; }

        /// <summary>
        /// International client.
        /// Международный клиент.
        /// </summary>
        [DataMember(Name = "int-client")]
        public InternationalClient? IntClient { get; set; }

        // properties with non-standard formatting

        /// <summary>
        /// Http error code reporting mode.
        /// Код http-ответа в случае ошибки расчетов: 1 - возвращать http-код ошибки, 0 - нет.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "errorcode")]
        public bool? ErrorCode { get; set; } = true;

        /// <summary>
        /// Tariff calculation in the closed delivery period.
        /// Расчет тарифа в закрытом для доставке периоде: 1 - рассчитывать, 0 - нет
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// Delivery date.
        /// Дата доставки.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "date")]
        public DateTime? Date { get; set; } = DateTime.Today;

        /// <summary>
        /// Delivery time.
        /// Время доставки.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "time")]
        public TimeSpan? Time { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// Starting date.
        /// Дата начала действия.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "date-from")]
        public DateTime? DateFrom { get; set; } = DateTime.Today;

        /// <summary>
        /// Ending date.
        /// Дата окончания действия.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "date-to")]
        public DateTime? DateTo { get; set; } = DateTime.Today;
    }
}
