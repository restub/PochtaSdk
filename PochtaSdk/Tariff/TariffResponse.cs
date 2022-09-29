using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;
using Restub.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariff/delivery term calculation response.
    /// Результат расчета тарифа/срока доставки.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Chapter 1.5)
    /// </summary>
    [DataContract]
    public class TariffResponse
    {
        [DataMember(Name = "version_api")]
        public int VersionApi { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "caption")]
        public string Caption { get; set; }

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

        [DataMember(Name = "date-first")]
        public int DateFirst { get; set; }

        [DataMember(Name = "postoffice")]
        public PostOffice[] PostOffices { get; set; }

        [DataMember(Name = "transtype")]
        public int Transtype { get; set; }

        [DataMember(Name = "transname")]
        public string Transname { get; set; }

        [DataMember(Name = "items")]
        public ServiceItem[] Services { get; set; }

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
    }
}
