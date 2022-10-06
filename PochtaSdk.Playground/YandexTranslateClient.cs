using System.Runtime.Serialization;
using RestSharp;
using Restub;
using Restub.DataContracts;

namespace PochtaSdk.Playground
{
    public class YandexTranslateClient : RestubClient
    {
        // obtain Yandex folderId and IAM token for your Yandex Cloud account
        public const string YandexFolderID = "-- folderId --";
        public const string YandexTranslateToken = "-- iam token --";

        public YandexTranslateClient(
            string baseUrl = "https://translate.api.cloud.yandex.net/translate/",
            string folderId = YandexFolderID,
            string token = YandexTranslateToken)
            : base(baseUrl, new YandexCredentials { Token = token })
        {
            FolderID = folderId;
        }

        public string FolderID { get; private set; }

        protected override Authenticator CreateAuthenticator() =>
            new YandexAuthenticator(this, (YandexCredentials)Credentials);

        public class YandexCredentials : Credentials
        {
            public string Token { get; set; }

            public override AuthToken Authenticate(RestubClient client) => new AuthToken();
        }

        public class YandexAuthenticator : Authenticator
        {
            public YandexAuthenticator(YandexTranslateClient client, YandexCredentials credentials) 
                : base(client, credentials)
            {
                Token = credentials.Token;
            }

            public string Token { get; private set; }

            public override void SetAuthToken(AuthToken authToken)
            {
            }

            public override void Authenticate(IRestClient client, IRestRequest request) =>
                request.AddHeader("Authorization", $"Bearer {Token}");
        }

        [DataContract]
        public class TranslationResponse
        {
            [DataMember(Name = "translations")]
            public Translation[] Translations { get; set; }

            [DataContract]
            public class Translation
            {
                [DataMember(Name = "text")]
                public string Text { get; set; }

                [DataMember(Name = "detectedLanguageCode")]
                public string DetectedLanguageCode { get; set; }
            }
        }

        public TranslationResponse Translate(string lang, params string[] texts) =>
            Post<TranslationResponse>("v2/translate", new
            {
                folderId = FolderID,
                texts,
                targetLanguageCode = lang
            });
    }
}
