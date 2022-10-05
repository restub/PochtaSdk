using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Restub;

namespace PochtaSdk.Playground
{
    public class YandexTranslateClient : RestubClient
    {
        public YandexTranslateClient(string apiKey, string baseUrl = "https://translate.yandex.net/api/v1.5/")
            : base(baseUrl)
        {
            ApiKey = apiKey;
        }

        public string ApiKey { get; private set; }

        [DataContract]
        public class Translation
        {
            [DataMember(Name = "code")]
            public string Code { get; set; }

            [DataMember(Name = "lang")]
            public string Lang { get; set; }

            [DataMember(Name = "text")]
            public string[] Text { get; set; }
        }

        public Translation Translate(string text, string lang) =>
            Get<Translation>("tr.json/translate", r => r
                .AddQueryParameter("key", ApiKey)
                .AddQueryParameter("text", text)
                .AddQueryParameter("lang", lang));
    }
}
