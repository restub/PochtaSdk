using System;
using System.Linq;

namespace PochtaSdk.Playground
{
    /// <summary>
    /// Helper class to generate Services.cs enumeration.
    /// </summary>
    public class ServiceTypeGenerator
    {
        // obtain Yandex folderId and IAM token for your Yandex Cloud account
        const string YandexFolderID = "-- folderId --";
        const string YandexTraslateToken = "-- iam token --";

        /// <summary>
        /// 1. Gets the list of services from Pochta.ru Tariff API
        /// 2. Translates service names in English
        /// 3. Generates the enumeration to be included in PochtaSdk project.
        /// </summary>
        public static void GenerateServices()
        {
            // use TariffClient to get the list of services
            var tariffClient = new TariffClient
            {
                Tracer = WriteDebugLog
            };

            // use Yandex translator to translate service names to English
            var translator = new YandexTranslateClient(YandexFolderID, YandexTraslateToken)
            {
                Tracer = WriteDebugLog
            };

            // get service names ordered by id
            var services = tariffClient.GetServices().Services.OrderBy(s => s.ID).ToArray();
            var russianTexts = services.Select(s => s.Name).ToArray();

            // translate service names to English
            var englishTexts = translator.Translate("en", russianTexts).Translations.Select(t => t.Text).ToArray();
            var translatedServices = services.Zip(englishTexts, (service, english) => new { service, english });

            // generate enumeration
            foreach (var svc in translatedServices)
            {
                var russianText = svc.service.Name;
                var name = ToTitleCase(russianText);
                var englishText = svc.english;
                var englishName = ToTitleCase(englishText);

                // redirect the output to the text file, i.e. Services.cs
                Console.WriteLine($@"
        /// <summary>
        /// {englishText}.
        /// {russianText}.
        /// </summary>
        {englishName} = {svc.service.ID},
        {name} = {svc.service.ID},");
            }
        }

        public static void WriteDebugLog(string format, params object[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Error.WriteLine(format, args);
            Console.ForegroundColor = oldColor;
        }

        private static string ToTitleCase(string s)
        {
            string clean(string p) =>
                string.Join(string.Empty, p.Where(char.IsLetterOrDigit));

            string titleCase(string p) =>
                string.IsNullOrWhiteSpace(p) ? string.Empty :
                    p.Substring(0, 1).ToUpperInvariant() + p.Substring(1).ToLowerInvariant();

            return string.Join(string.Empty,
                s.Split(' ', '-', '/', '\'', '"', '«', '»')
                    .Select(clean)
                    .Select(titleCase));
        }
    }
}