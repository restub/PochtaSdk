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
    public class TariffResponse : BaseResponse
    {
        // <summary>
        /// Service caption.
        /// Название сервиса.
        /// </summary>
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

        /// <summary>
        /// Total amount for the ground transport.
        /// Итоговая сумма за почтовый наземный сбор.
        /// </summary>
        [DataMember(Name = "ground")]
        public TariffAmount GroundAmount { get; set; }

        /// <summary>
        /// Total amount for the avia transport.
        /// Итоговая сумма за авиасбор.
        /// </summary>
        [DataMember(Name = "avia")]
        public TariffAmount AviaAmount { get; set; }

        /// <summary>
        /// Total amount for the additional services.
        /// Тариф за дополнительную услугу.
        /// </summary>
        [DataMember(Name = "service")]
        public TariffAmount ServiceAmount { get; set; }

        /// <summary>
        /// Total payment amount, no VAT, in cents.
        /// Итоговая сумма платы без НДС в копейках (в валюте расчета).
        /// </summary>
        [DataMember(Name = "pay")]
        public int? Pay { get; set; }

        /// <summary>
        /// Total payment amount, including VAT, in cents.
        /// Итоговая сумма платы c НДС в копейках (в валюте расчета).
        /// </summary>
        [DataMember(Name = "paynds")]
        public int? PayNds { get; set; }

        /// <summary>
        /// VAT percents.
        /// Ставка НДС в процентах.
        /// </summary>
        [DataMember(Name = "ndsrate")]
        public int? NdsRate { get; set; }

        /// <summary>
        /// VAT amount, in cents.
        /// Сумма НДС в копейках (в валюте расчета).
        /// </summary>
        [DataMember(Name = "nds")]
        public int? Nds { get; set; }

        /// <summary>
        /// Total payment amount, in cents when paid with stamps.
        /// Итоговая сумма платы в копейках при оплате почтовыми марками, всегда кратна рублю.
        /// </summary>
        [DataMember(Name = "paymark")]
        public int? PayMark { get; set; }

        /// <summary>
        /// Total payment amount, in cents when paid with SDR.
        /// Итоговая сумма платы в копейках при оплате в СПЗ, всегда кратна рублю.
        /// </summary>
        [DataMember(Name = "paysdr")]
        public int? PaySdr { get; set; }

        /// <summary>
        /// SDR exchange rate.
        /// Курс СПЗ.
        /// </summary>
        [DataMember(Name = "sdr")]
        public int Sdr { get; set; }

        /// <summary>
        /// Total payment amount for additional services, no VAT, cents.
        /// Итоговая сумма платы за дополнительные услуги без НДС в копейках (в валюте расчета)
        /// </summary>
        [DataMember(Name = "paymoney")]
        public int? PayMoney { get; set; }

        /// <summary>
        /// Total payment amount for additional services, including VAT, cents.
        /// Итоговая сумма платы за дополнительные услуги с НДС в копейках (в валюте расчета)
        /// </summary>
        [DataMember(Name = "paymoneynds")]
        public int? PayMoneyNds { get; set; }

        /// <summary>
        /// Volume.
        /// Объем.
        /// </summary>
        [DataMember(Name = "volume")]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Duration.
        /// Длительность.
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
        /// Starting date.
        /// Дата начала действия.
        /// </summary>
        [DataMember(Name = "date-from"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Ending date.
        /// Дата окончания действия.
        /// </summary>
        [DataMember(Name = "date-to"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateTo { get; set; }

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

        /// <summary>
        /// Starting date of the service.
        /// Дата начала предоставления услуги.
        /// </summary>
        [DataMember(Name = "date-begin"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateBegin { get; set; }

        /// <summary>
        /// Ending date of the service.
        /// Дата окончания предоставления услуги.
        /// </summary>
        [DataMember(Name = "date-end"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? DateEnd { get; set; }

        [DataMember(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Delivery terms.
        /// Контрольные сроки доставки.
        /// </summary>
        [DataMember(Name = "delivery")]
        public DeliveryTerms DeliveryTerms { get; set; }
    }
}
