using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Restub;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Otpravka API exception class.
    /// </summary>
    [Serializable]
    public class OtpravkaException : RestubException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaException"/> class.
        /// </summary>
        /// <param name="code">Http status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public OtpravkaException(HttpStatusCode code, string message, Exception innerException = null)
            : base(code, AdjustErrorMessage509(code, message, innerException), innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaException"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public OtpravkaException(string message, Exception innerException = null)
            : this(HttpStatusCode.OK, message, innerException)
        {
        }

        /// <summary>
        /// Adjusts API token limit exception message when obscure deserialization message is reported.
        /// </summary>
        /// <param name="code">Http status code</param>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        /// <returns></returns>
        private static string AdjustErrorMessage509(HttpStatusCode code, string message, Exception innerException)
        {
            if (code != (HttpStatusCode)509)
            {
                return message;
            }

            bool isSerializationException(Exception ex) =>
                ex is JsonReaderException || ex is JsonSerializationException ||
                    (ex.InnerException != null && isSerializationException(ex.InnerException));

            bool isIOException(Exception ex) =>
                ex is IOException ||
                    (ex.InnerException != null && isSerializationException(ex.InnerException));

            if (string.IsNullOrWhiteSpace(message) ||
                isSerializationException(innerException) ||
                isIOException(innerException))
            {
                return "API request limit exceeded? Error response cannot be deserialized." +
                    (!string.IsNullOrWhiteSpace(message) ? " " + message : string.Empty);
            }

            return message;
        }
    }
}
