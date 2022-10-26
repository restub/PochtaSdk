using System.Runtime.Serialization;
using OksmCountryCode = PochtaSdk.Tariff.OksmCountryCode;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Customs declaration entry for international shippings.
    /// Вложение таможенной декларации (для международных отправлений).
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class PackageEntry
    {
        /// <summary>
        /// Количество
        /// </summary>
        [DataMember(Name = "amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Код страны происхождения.
        /// </summary>
        [DataMember(Name = "country-code")]
        public OksmCountryCode CountryCode { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Код ТНВЭД
        /// </summary>
        [DataMember(Name = "tnved-code")]
        public string TnvedCode { get; set; }

        /// <summary>
        /// Торговая марка
        /// </summary>
        [DataMember(Name = "trademark")]
        public string Trademark { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС)
        /// </summary>
        [DataMember(Name = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Вес товара (в граммах)
        /// </summary>
        [DataMember(Name = "weight")]
        public int Weight { get; set; }

        //---------------------------------

        /// <summary>
        /// Порядковый номер (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "entry-number")]
        public int? EntryNumber { get; set; }
    }
}