using System;
using System.Linq;

namespace PochtaSdk.Playground
{
    public class ServiceTypeGenerator
    {
        public static void GenerateServices()
        {
            // use TariffClient to get the list of services
            var tariffClient = new TariffClient
            {
                Tracer = Console.WriteLine
            };

            // use Yandex translator to translate service names to English
            var apiKey = "yandexApiKey";
            var translator = new YandexTranslateClient(apiKey);

            // generate enumeration
            var services = tariffClient.GetServices();
            foreach (var svc in services.Services.OrderBy(s => s.ID))
            {
                var russian = svc.Name;
                var name = ToTitleCase(svc.Name);
                var english = translator.Translate(russian, "ru-en").Text;
                var englishText = string.Join(Environment.NewLine, english);
                var englishName = ToTitleCase(englishText);

                Console.WriteLine($@"
        /// <summary>
        /// {english}.
        /// {russian}.
        /// </summary>
        {englishName} = {svc.ID},
        {name} = {svc.ID},
");
                break;
            }

            Console.ReadKey();
        }

        private static string ToTitleCase(string s)
        {
            string clean(string p) =>
                string.Join(string.Empty, p.Where(char.IsLetterOrDigit));

            string titleCase(string p) =>
                string.IsNullOrWhiteSpace(p) ? string.Empty :
                    p.Substring(0, 1).ToUpperInvariant() + p.Substring(1).ToLowerInvariant();

            return string.Join(string.Empty, s.Split(' ').Select(clean).Select(titleCase));
        }
    }
}