using System;
using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Base response type.
    /// Результат расчета, базовый класс.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Chapters 1.5, 2.6)
    /// </summary>
    [DataContract]
    public class BaseResponse : IHasErrors
    {
        /// <summary>
        /// API version, should be 2.
        /// Версия API, равно 2.
        /// </summary>
        [DataMember(Name = "version_api")]
        public int VersionApi { get; set; }

        /// <summary>
        /// Service version.
        /// Версия сервиса.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; set; }

        /// <summary>
        /// List of calculation errors.
        /// Список ошибок расчета.
        /// </summary>
        [DataMember(Name = "errors")]
        public ErrorReport[] Errors { get; set; }

        /// <inheritdoc/>
        public bool HasErrors() =>
            Errors != null && Errors.Any();

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            string.Join(Environment.NewLine,
                (Errors ?? Enumerable.Empty<ErrorReport>())
                    .Select(e => e.Message));
    }
}
