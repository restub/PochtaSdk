using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Error report.
    /// Сообщение об ошибке.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.2)
    /// </summary>
    [DataContract]
    public class ErrorReport
    {
        [DataMember(Name = "msg")]
        public string Message { get; set; }

        [DataMember(Name = "code")]
        public ErrorCode ErrorCode { get; set; }

        [DataMember(Name = "type")]
        public ErrorType ErrorType { get; set; }
    }
}
