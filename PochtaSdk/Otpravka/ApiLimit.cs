using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// API request limit.
    /// Текущее количество запросов по API
    /// https://otpravka.pochta.ru/specification#/nogroup-count_request_api
    /// </summary>
    [DataContract]
    public struct ApiLimit
    {
        /// <summary>
        /// Количество запросов по API разрешенных для клиента
        /// </summary>
        [DataMember(Name = "allowed-count")]
        public int AllowedCount { get; set; }

        /// <summary>
        /// Текущее количество по API у клиента
        /// </summary>
        [DataMember(Name = "current-count")]
        public int CurrentCount { get; set; }
    }
}
