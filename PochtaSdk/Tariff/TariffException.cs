using System;
using System.Net;
using Restub;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariff REST API exception.
    /// </summary>
    [Serializable]
    public class TariffException : RestubException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffException"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public TariffException(string message, Exception innerException = null)
            : this(HttpStatusCode.OK, message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TariffException"/> class.
        /// </summary>
        /// <param name="code">Status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public TariffException(HttpStatusCode code, string message, Exception innerException = null)
            : base(code, message, innerException)
        {
        }
    }
}
