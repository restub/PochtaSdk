using System.Collections.Generic;
using System.Runtime.Serialization;
using PochtaSdk.Tariff;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Shipping order goods contents item.
    /// Элемент товарного вложения РПО.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// </summary>
    [DataContract]
    public class OrderGoodsItem
    {
        /// <summary>
        /// Код (маркировка) товара
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Код страны происхождения.
        /// </summary>
        [DataMember(Name = "country-code")]
        public OksmCountryCode CountryCode { get; set; }

        /// <summary>
        /// Номер таможенной декларации
        /// </summary>
        [DataMember(Name = "customs-declaration-number")]
        public string CustomsDeclarationNumber { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Акциз (копейки)
        /// </summary>
        [DataMember(Name = "excise")]
        public int Excise { get; set; }

        /// <summary>
        /// Признак товар или услуга
        /// </summary>
        [DataMember(Name = "goods-type")]
        public OrderGoodsItemType GoodsType { get; set; }

        /// <summary>
        /// Declared value, cents
        /// Объявленная ценность (копейки)
        /// </summary>
        [DataMember(Name = "insr-value")]
        public int DeclaredValue { get; set; }

        /// <summary>
        /// Номенклатура (артикул) товара
        /// </summary>
        [DataMember(Name = "item-number")]
        public string ItemNumber { get; set; }

        /// <summary>
        /// Признак предмета расчета
        /// </summary>
        [DataMember(Name = "lineattr")]
        public OrderGoodsLineAttr LineAttr { get; set; }

        /// <summary>
        /// Признак способа расчета
        /// </summary>
        [DataMember(Name = "payattr")]
        public OrderGoodsPayAttr PayAttr { get; set; }

        /// <summary>
        /// Количество товара
        /// </summary>
        [DataMember(Name = "quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// ИНН поставщика товара
        /// </summary>
        [DataMember(Name = "supplier-inn")]
        public string SupplierInn { get; set; }

        /// <summary>
        /// Наименование поставщика товара
        /// </summary>
        [DataMember(Name = "supplier-name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// Телефон поставщика товара
        /// </summary>
        [DataMember(Name = "supplier-phone")]
        public string SupplierPhone { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС)
        /// </summary>
        [DataMember(Name = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Ставка НДС: Без НДС(-1), 0, 10, 110, 20, 120
        /// </summary>
        [DataMember(Name = "vat-rate")]
        public int VatRate { get; set; }

        /// <summary>
        /// Вес товара (в граммах)
        /// </summary>
        [DataMember(Name = "weight")]
        public int Weight { get; set; }

        // -------------------

        /// <summary>
        /// Категория товара (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "category-feature")]
        public string CategoryFeature { get; set; }

        /// <summary>
        /// Номер товара в списке вложений (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "id")]
        public int? ID { get; set; }

        /// <summary>
        /// Статус возврата, вложения ЕКОМ (поле появляется только при запросе заказа)
        /// </summary>
        [DataMember(Name = "returned")]
        public bool? Returned { get; set; }
    }
}
