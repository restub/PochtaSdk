using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Dimension type.
    /// Типоразмер.
    /// https://otpravka.pochta.ru/specification#/enums-dimension-type
    /// </summary>
    [DataContract]
    public enum DimensionType
    {
        /// <summary>
        /// Small, up to 260х170х80 mm
        /// Маленький, до 260х170х80 мм
        /// </summary>
        [EnumMember(Value = "S")]
        Small,

        /// <summary>
        /// Medium, up to 300х200х150 mm
        /// Средний, до 300х200х150 мм
        /// </summary>
        [EnumMember(Value = "M")]
        Medium,

        /// <summary>
        /// Large, up to 400х270х180 mm
        /// Большой, до 400х270х180 мм
        /// </summary>
        [EnumMember(Value = "L")]
        Large,

        /// <summary>
        /// Extra Large, up to 530х260х220 mm
        /// Очень большой, до 530х260х220 мм
        /// </summary>
        [EnumMember(Value = "XL")]
        XtraLarge,

        /// <summary>
        /// Oversized, all sizes up to 1400 mm, each size up to 60 mm
        /// Негабарит, сумма сторон не более 1400 мм, сторона не более 600 мм
        /// </summary>
        [EnumMember(Value = "OVERSIZED")]
        Oversized,
    }
}
