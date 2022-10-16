using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order goods line attr.
    /// Справочнк признаков предмета расчета.
    /// https://otpravka.pochta.ru/specification#/enums-lineattr
    /// </summary>
    public enum OrderGoodsLineAttr
    {
        /// <summary>
        /// Goods description, no excise
        /// О реализуемом товаре, за исключением подакцизного товара (наименование и иные сведения, описывающие товар)
        /// </summary>
        GoodsWithoutExcise = 1,

        /// <summary>
        /// Goods description, with excise
        /// О реализуемом подакцизном товаре (наименование и иные сведения, описывающие товар)
        /// </summary>
        GoodsWithExcise = 2,

        /// <summary>
        /// Service description
        /// Об оказываемой услуге (наименование и иные сведения, описывающие услугу)
        /// </summary>
        Service = 4,
    }
}
