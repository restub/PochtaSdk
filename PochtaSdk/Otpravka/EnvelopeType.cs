using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Envelope type.
    /// Тип конверта - ГОСТ Р 51506-99..
    /// https://otpravka.pochta.ru/specification#/enums-base-envelope-type
    /// </summary>
    [DataContract]
    public enum EnvelopeType
    {
        /// <summary>
        /// 229 x 324 mm
        /// </summary>
        [EnumMember(Value = "C4")]
        C4,

        /// <summary>
        /// 162 x 229 mm
        /// </summary>
        [EnumMember(Value = "C5")]
        C5,

        /// <summary>
        /// 114 x 162 mm
        /// </summary>
        [EnumMember(Value = "C6")]
        C6,

        /// <summary>
        /// 110 x 220 mm
        /// </summary>
        [EnumMember(Value = "DL")]
        DL,

        /// <summary>
        /// 105 x 148 mm
        /// </summary>
        [EnumMember(Value = "A6")]
        A6,

        /// <summary>
        /// 74 x 105 mm
        /// </summary>
        [EnumMember(Value = "A7")]
        A7,

        /// <summary>
        /// Sticker ЗОО X6 (99 x 105 mm)
        /// </summary>
        [EnumMember(Value = "OX")]
        OX,

        /// <summary>
        /// Стикер ЗОО А6 (105 x 148,5 mm)
        /// </summary>
        [EnumMember(Value = "OA")]
        OA,
    }
}
