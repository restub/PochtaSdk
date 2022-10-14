using Restub;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Pochta.ru otpravka API authenticator.
    /// https://otpravka.pochta.ru/specification#/authorization-key
    /// </summary>
    public class OtpravkaAuthenticator : Authenticator<OtpravkaClient, OtpravkaAuthToken>
    {
        /// <summary>
        /// Ininitializes a new instance of the <see cref="OtpravkaAuthenticator"/> class.
        /// </summary>
        /// <param name="apiClient">Rest API client.</param>
        /// <param name="credentials"><see cref="OtpravkaCredentials"/> instance.</param>
        public OtpravkaAuthenticator(OtpravkaClient apiClient, OtpravkaCredentials credentials)
            : base(apiClient, credentials)
        {
        }

        /// <inheritdoc/>
        public override void InitAuthHeaders(OtpravkaAuthToken authToken)
        {
            AuthHeaders["Authorization"] = $"AccessToken {authToken.AccessToken}";
            AuthHeaders["X-User-Authorization"] = $"Basic {authToken.AuthorizationKey}";
        }
    }
}
