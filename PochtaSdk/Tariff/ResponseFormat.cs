using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Specifies the response format.
    /// </summary>
    [DataContract]
    public enum ResponseFormat
    {
        [EnumMember(Value = "json")]
        Json,

        [EnumMember(Value = "jsontext")]
        JsonText,

        [EnumMember(Value = "html")]
        Html,

        [EnumMember(Value = "htmlfull")]
        HtmlFull,

        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "easy")]
        Easy,
    }
}
