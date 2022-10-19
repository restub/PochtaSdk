using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Country information.
    /// Информация о стране.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.6)
    /// </summary>
    [DataContract]
    public class CountryInfo
    {
        /// <summary>
        /// Country identity.
        /// Код страны.
        /// </summary>
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Country name.
        /// Наименование страны.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Actual date.
        /// Дата актуальности.
        /// </summary>
        [DataMember(Name = "date"), JsonConverter(typeof(TariffDateOnlyConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Alternative country names.
        /// Альтернативные названия страны.
        /// </summary>
        [DataMember(Name = "altnames")]
        public CountryAltName[] AltNames { get; set; }

        /// <summary>
        /// Letter requisites.
        /// Реквизиты для писем.
        /// </summary>
        [DataMember(Name = "letter")]
        public CountryShippingInfo Letter { get; set; }

        /// <summary>
        /// Parcel requisites.
        /// Реквизиты для посылок.
        /// </summary>
        [DataMember(Name = "parcel")]
        public CountryShippingInfo Parcel { get; set; }

        [DataMember(Name = "ems")]
        public CountryShippingInfo Ems { get; set; }

        [DataMember(Name = "note")]
        public string Note { get; set; }

        [DataMember(Name = "item-warning")]
        public string ItemWarning { get; set; }

        [DataMember(Name = "item-stop")]
        public string ItemStop { get; set; }
    }
}
