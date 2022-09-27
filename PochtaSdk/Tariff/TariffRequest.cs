using System;
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
        public TariffObjectType Object { get; set; } = TariffObjectType.LetterRegular;

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
        /// Weight, grams.
        /// Вес, в граммах.
        /// </summary>
        [DataMember(Name = "weight")]
        public int? Weight { get; set; }

        [DataMember(Name = "group")]
        public int? Group { get; set; } = 0;

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
        public DirectionCategory? DirectCtg { get; set; }

        // properties with non-standard formatting

        /// <summary>
        /// Http error code reporting mode.
        /// Код http-ответа в случае ошибки расчетов: 1 - возвращать http-код ошибки, 0 - нет.
        /// </summary>
        [IgnoreDataMember, DataMember(Name = "errorcode")]
        public bool? ReturnHttpErrorCode { get; set; } = true;

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
    }
}
