using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Pochta.ru otpravka API authentication token.
    /// https://otpravka.pochta.ru/specification#/authorization-token
    /// </summary>
    public class OtpravkaAuthToken : AuthToken
    {
        public string AccessToken { get; set; }

        public string AuthorizationKey { get; set; }
    }
}
