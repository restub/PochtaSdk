using System.Runtime.Serialization;
using RestSharp;
using RestSharp.Authenticators;
using Restub;

namespace PochtaSdk.Playground
{
    /// <summary>
    /// Sample Yandex Translate REST API client.
    /// </summary>
    public class YandexTranslateClient : RestubClient, IAuthenticator
    {
        // obtain Yandex folderId and IAM token for your Yandex Cloud account
        public const string YandexFolderID = "-- folderId --";
        public const string YandexTranslateToken = "-- iam token --";
        public const string YandexTranslateUrl = "https://translate.api.cloud.yandex.net/translate/";

        public YandexTranslateClient(string baseUrl = YandexTranslateUrl, string folderId = YandexFolderID, string token = YandexTranslateToken)
            : base(baseUrl)
        {
            FolderID = folderId;
            Token = token;
        }

        private string FolderID { get; set; }

        private string Token { get; set; }

        public void Authenticate(IRestClient client, IRestRequest request) =>
            request.AddHeader("Authorization", $"Bearer {Token}");

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
