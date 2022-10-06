using System;
using System.Collections.Generic;
using System.Linq;
using PochtaSdk.Tariff;

namespace PochtaSdk.Playground
{
    /// <summary>
    /// Helper class to generate ObjectType.cs enumeration.
    /// </summary>
    public static class ObjectTypeGenerator
    {
        /// <summary>
        /// 1. Gets the list of object types from Pochta.ru Tariff API
        /// 2. Normalizes some type names to avoid known translation pitfalls
        /// 3. Translates object type names in English
        /// 4. Generates the enumeration to be included in PochtaSdk project.
        /// </summary>
        public static void GenerateObjectTypes()
        {
            // use TariffClient to get the list of tariffication objects
            var tariffClient = new TariffClient
            {
                Tracer = WriteDebugLog
            };

            // use Yandex translator to translate object names to English
            var translator = new YandexTranslateClient
            {
                Tracer = WriteDebugLog
            };

            // get and traverse object categories
            var root = tariffClient.GetCategories();
            var categories = Traverse(root.Categories).ToList();

            // get tariffication object types ordered by id
            var objectTypesQuery = 
                from c in categories 
                from t in tariffClient.GetObjectTypes(c.ID).ObjectTypes ?? Enumerable.Empty<ObjectTypeInfo>()
                orderby t.ID
                select t;
            var objectTypes = objectTypesQuery.DistinctBy(t => t.ID).ToList();

            // get service names ordered by id and unify names
            var russianTexts = objectTypes.Select(s => s.Name).ToArray();
            russianTexts = UnifyNames(russianTexts);

            // translate service names to English
            var englishTexts = translator.Translate("en", russianTexts).Translations.Select(t => t.Text).ToArray();
            var translatedTypes = objectTypes.Zip(englishTexts, (objectType, english) => new { objectType, english });

            // generate enumeration
            foreach (var obj in translatedTypes)
            {
                var russianText = obj.objectType.Name;
                var name = ToTitleCase(russianText);
                var englishText = obj.english;
                var englishName = ToTitleCase(englishText);

                // redirect the output to the text file, i.e. Services.cs
                Console.WriteLine($@"
        /// <summary>
        /// {englishText}.
        /// {russianText}.
        /// </summary>
        {englishName} = {obj.objectType.ID},
        {name} = {obj.objectType.ID},");
            }
        }

        private static string[] UnifyNames(string[] russianTexts)
        {
            string unifyName(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }

                if (name.StartsWith("EMS"))
                {
                    name = "Посылка " + name;
                }

                if (name.Contains("Бандероль"))
                {
                    name = name.Replace("Бандероль", "Wrapper");
                }

                if (name.Contains("простое") || name.Contains("простая") ||
                    name.Contains("обыкновенная") || name.Contains("обычная") ||
                    name.Contains("обыкновенный") || name.Contains("обычный"))
                { 
                    name = name.Replace("простое", "regular").Replace("простая", "regular")
                        .Replace("обыкновенная", "regular").Replace("обычная", "regular")
                        .Replace("обыкновенный", "regular").Replace("обычный", "regular");
                }

                if (name.Contains("заказное") || name.Contains("заказная") || name.Contains("заказной"))
                {
                    name = name.Replace("заказное", "registered")
                        .Replace("заказная", "registered")
                        .Replace("заказной", "registered");
                }

                if (name.StartsWith("Письмо"))
                {
                    name = name.Replace("Письмо", "Letter");
                }

                if (name.IndexOf("перевод", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    name = name.Replace("перевод", "money transfer").Replace("Перевод", "Money transfer");
                }

                // avoid translating «Форсаж» as «Fast and Furious», prefer French «forçage» but without the diacritic
                if (name.IndexOf("Форсаж", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    name = name.Replace("Форсаж", "Forcage").Replace("форсаж", "forcage");
                }

                if (name.StartsWith("Посылка"))
                {
                    name = name.Replace("Посылка", "Parcel");
                }

                if (name.StartsWith("Расфальцовка"))
                {
                    name = name.Replace("Расфальцовка", "Unfolding");
                }

                if (name.StartsWith("Мешок М"))
                {
                    name = name.Replace("Мешок М", "Bag/M");
                }

                if (name.Contains("1 класса"))
                {
                    name = name.Replace("1 класса", "1 class");
                }

                return name;
            }

            return russianTexts.Select(unifyName).ToArray();
        }

        public static IEnumerable<CategoryInfo> Traverse(IEnumerable<CategoryInfo> list)
        {
            foreach (var cat in list ?? Enumerable.Empty<CategoryInfo>())
            {
                yield return cat;

                foreach (var cc in Traverse(cat.Children))
                {
                    yield return cc;
                }
            }
        }

        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer = null)
        {
            if (enumerable == null || !enumerable.Any())
            {
                yield break;
            }

            var keys = new HashSet<TKey>(comparer);
            foreach (var item in enumerable)
            {
                var key = keySelector(item);
                if (keys.Add(key))
                {
                    yield return item;
                }
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