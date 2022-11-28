using System;
using PochtaSdk.Otpravka;
using PochtaSdk.Toolbox;
using RestSharp;
using RestSharp.Authenticators;
using Restub;
using Restub.DataContracts;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru Otpravka API client
    /// https://otpravka.pochta.ru/specification
    /// </summary>
    public partial class OtpravkaClient : RestubClient
    {
        /// <summary>
        /// Base API URL.
        /// </summary>
        public const string BaseUrl = "https://otpravka-api.pochta.ru/";

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaClient"/> class.
        /// </summary>
        /// <param name="accessToken">Access token.</param>
        /// <param name="userName">User name.</param>
        /// <param name="password">Password.</param>
        public OtpravkaClient(string accessToken, string userName, string password)
            : this(new OtpravkaCredentials
            {
                AccessToken = accessToken,
                UserName = userName,
                Password = password,
            })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaClient"/> class.
        /// </summary>
        /// <param name="credentials">Credentials.</param>
        public OtpravkaClient(OtpravkaCredentials credentials)
            : this(BaseUrl, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpravkaClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base API URL.</param>
        /// <param name="credentials">Credentials.</param>
        public OtpravkaClient(string baseUrl, OtpravkaCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(PochtaSdk)}.{nameof(OtpravkaClient)} v{LibraryVersion}, {base.LibraryName}";

        /// <inheritdoc/>
        protected override IAuthenticator GetAuthenticator() =>
            new OtpravkaAuthenticator(this, (OtpravkaCredentials)Credentials);

        /// <inheritdoc/>
        protected override IRestubSerializer CreateSerializer() =>
            new PochtaSerializer();

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse res, string msg, IHasErrors errors) =>
            new OtpravkaException(res.StatusCode, msg, base.CreateException(res, msg, errors))
            {
                ErrorResponseText = res.Content,
            };

        /// <inheritdoc/>
        protected override IHasErrors DeserializeErrorResponse(IRestResponse response) =>
            Serializer.Deserialize<ErrorWithSubCode>(response);
    }
}
