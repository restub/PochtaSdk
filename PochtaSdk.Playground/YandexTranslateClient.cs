using System;
using System.Runtime.Serialization;
using RestSharp;
using RestSharp.Authenticators;
using Restub;

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
            : base(baseUrl)
        {
            FolderID = folderId;
            Token = token;
        }

        private string FolderID { get; set; }

        private string Token { get; set; }

        protected override IAuthenticator CreateAuthenticator() =>
            new YandexAuthenticator
            {
                GetToken = () => Token
            };

        public class YandexAuthenticator : IAuthenticator
        {
            public Func<string> GetToken { private get; set; }

            public void Authenticate(IRestClient client, IRestRequest request) =>
                request.AddHeader("Authorization", $"Bearer {GetToken()}");
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
