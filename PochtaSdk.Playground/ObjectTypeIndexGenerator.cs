using System;
using System.Collections.Generic;
using System.Linq;
using PochtaSdk.Tariff;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Playground
{
    /// <summary>
    /// Helper class to generate ObjectType.cs enumeration.
    /// </summary>
    public static class ObjectTypeIndexGenerator
    {
        /// <summary>
        /// 1. Gets the list of object types from Pochta.ru Tariff API
        /// 2. Generates the dictionary: ObjectType -> CategoryID.
        /// </summary>
        public static void GenerateObjectTypesIndex()
        {
            // use TariffClient to get the list of tariffication objects
            var tariffClient = new TariffClient
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
                select new
                {
                    CategoryID = c.ID,
                    ObjectType = t.ObjectType,
                };

            var objectTypes = objectTypesQuery
                .DistinctBy(t => t.ObjectType)
                .ToDictionary(t => t.ObjectType, t => t.CategoryID);

            // generate names index
            var enumValues = typeof(ObjectType).GetFields()
                .Where(f => f.IsStatic)
                .Select(f => new { Name = f.Name, Value = (int)f.GetValue(null) })
                .ToLookup(f => f.Value)
                .Select(g => new { g.Key, Name = g.OrderBy(x => x.Name).Select(x => x.Name).First() })
                .ToDictionary(g => g.Key, g => g.Name);

            // generate the index
            Console.Write(@"
            var index = new Dictionary<ObjectType, int>
            {");
            foreach (var pair in objectTypes)
            {
                string objectType;
                if (enumValues.TryGetValue((int)pair.Key, out objectType))
                {
                    objectType = $"ObjectType.{objectType}";
                }
                else
                {
                    objectType = $"(ObjectType){(int)pair.Key}";
                }

                // redirect the output to the text file, i.e. ObjectTypeIndex.cs
                Console.Write($@"
                {{ {objectType}, {pair.Value} }},");
            }
            Console.WriteLine(@"
            };");
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

        public static void WriteDebugLog(string format, params object[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Error.WriteLine(format, args);
            Console.ForegroundColor = oldColor;
        }
    }
}