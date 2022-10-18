using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            : base(code, message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaException"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public OtpravkaException(string message, Exception innerException = null)
            : base(HttpStatusCode.OK, message, innerException)
        {
        }
    }
}
