using System;
using System.Linq;
using Restub.Toolbox;

namespace PochtaSdk.Playground
{
    /// <summary>
    /// Helper class to generate Services.cs enumeration.
    /// </summary>
    public class ServiceTypeGenerator
    {
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
            var translator = new YandexTranslateClient
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
                var name = russianText.ToTitleCase();
                var englishText = svc.english;
                var englishName = englishText.ToTitleCase();

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
    }
}