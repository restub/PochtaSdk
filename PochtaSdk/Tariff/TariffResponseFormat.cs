using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Specifies the response format.
    /// </summary>
    [DataContract]
    public enum TariffResponseFormat
    {
        [EnumMember(Value = "json")]
        Json,

        [EnumMember(Value = "html")]
        Html,
    }
}
