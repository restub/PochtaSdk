using System;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;
using Restub.DataContracts;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariff/delivery term calculation response.
    /// Результат расчета тарифа/срока доставки.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Chapter 1.5)
    /// </summary>
    [DataContract]
    public class TariffResponse : IHasErrors
    {
        // <summary>
        /// API version, should be 2.
        /// Версия API, равно 2.
        /// </summary>
        [DataMember(Name = "version_api")]
        public int VersionApi { get; set; }

        // <summary>
        /// Service version.
        /// Версия сервиса.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; set; }

        // <summary>
        /// Service caption.
        /// Название сервиса.
        /// </summary>
        [DataMember(Name = "caption")]
        public string Caption { get; set; }

        // <summary>
        /// List of calculation errors.
        /// Список ошибок расчета.
        /// </summary>
        [DataMember(Name = "errors")]
        public ErrorReport[] Errors { get; set; }

        /// <summary>
        /// Tariff calculation object type code.
        /// Код типа объекта расчета.
        /// </summary>
        [DataMember(Name = "id")]
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// Tariff calculation object type name.
        /// Название типа объекта расчета.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "mailtype")]
        public int MailType { get; set; }

        [DataMember(Name = "mailctg")]
        public int MailCategory { get; set; }

        [DataMember(Name = "directctg")]
        public int DirectCategory { get; set; }

        /// <summary>
        /// Source postal code.
        /// Почтовый индекс отправления.
        /// </summary>
        [DataMember(Name = "from")]
        public int FromPostCode { get; set; }

        /// <summary>
        /// Destination postal code.
        /// Почтовый индекс назначения.
        /// </summary>
        [DataMember(Name = "to")]
        public int ToPostCode { get; set; }

        /// <summary>
        /// Weight of a package.
        /// Вес отправления.
        /// </summary>
        [DataMember(Name = "weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Packaging information.
        /// Информация об упаковке.
        /// </summary>
        [DataMember(Name = "pack")]
        public PackageInfo PackageInfo { get; set; }

        [DataMember(Name = "date"), JsonConverter(typeof(TariffDateOnlyConverter))] // date only
        public DateTime Date { get; set; }

        [DataMember(Name = "time"), JsonConverter(typeof(TariffTimeOnlyConverter))] // time only
        public TimeSpan Time { get; set; }

        /// <summary>
        /// Starting date of the tariff.
        /// Дата начала действия тарифа.
        /// </summary>
        [DataMember(Name = "date-first"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateFirst { get; set; }

        /// <summary>
        /// Ending date of the tariff.
        /// Дата окончания действия тарифа.
        /// </summary>
        [DataMember(Name = "date-last"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateLast { get; set; }

        /// <summary>
        /// Starting date of the delivery terms.
        /// Дата начала действия контрольных сроков.
        /// </summary>
        [DataMember(Name = "delivery-date-first"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DeliveryDateFirst { get; set; }

        /// <summary>
        /// Ending date of the delivery terms.
        /// Дата окончания действия контрольных сроков.
        /// </summary>
        [DataMember(Name = "delivery-date-last"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DeliveryDateLast { get; set; }

        [DataMember(Name = "postoffice")]
        public PostOffice[] PostOffices { get; set; }

        [DataMember(Name = "transtype")]
        public int Transtype { get; set; }

        [DataMember(Name = "transname")]
        public string Transname { get; set; }

        /// <summary>
        /// Tariff calculation items.
        /// Список составных частей расчета.
        /// </summary>
        [DataMember(Name = "items")]
        public ServiceItem[] Items { get; set; }

        [DataMember(Name = "isgroup")]
        public int IsGroup { get; set; }

        [DataMember(Name = "isdogovor")]
        public int IsDogovor { get; set; }

        [DataMember(Name = "ground")]
        public TariffAmount Amount { get; set; }

        [DataMember(Name = "paymoney")]
        public int PayMoney { get; set; }

        [DataMember(Name = "paymoneynds")]
        public int PayMoneyNds { get; set; }

        [DataMember(Name = "pay")]
        public int Pay { get; set; }

        [DataMember(Name = "paynds")]
        public int PayNds { get; set; }

        [DataMember(Name = "ndsrate")]
        public int NdsRate { get; set; }

        [DataMember(Name = "nds")]
        public int Nds { get; set; }

        [DataMember(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Delivery terms.
        /// Контрольные сроки доставки.
        /// </summary>
        [DataMember(Name = "delivery")]
        public DeliveryTerms DeliveryTerms { get; set; }

        public bool HasErrors() =>
            Errors != null && Errors.Any();

        public string GetErrorMessage() =>
            string.Join(Environment.NewLine,
                (Errors ?? Enumerable.Empty<ErrorReport>())
                    .Select(e => e.Message));
    }
}
