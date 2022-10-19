using System;
using System.Linq;
using PochtaSdk.Tariff;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru tariffication API client, REST API methods.
    /// Клиент сервиса тарификации pochta.ru, методы REST API.
    /// https://tariff.pochta.ru/
    /// </remarks>
    public partial class TariffClient
    {
        /// <summary>
        /// Calculates the tariff and delivery terms.
        /// Расчет тарифа и контрольных сроков доставки.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public TariffResponse Calculate(TariffRequest request) =>
            Get<TariffResponse>("v2/calculate/tariff/delivery", "json", request);

        /// <summary>
        /// Calculates the tariff.
        /// Расчет тарифа.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public TariffResponse CalculateTariff(TariffRequest request) =>
            Get<TariffResponse>("v2/calculate/tariff", "json", request);

        /// <summary>
        /// Calculates the delivery terms.
        /// Расчет контрольных сроков доставки.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public TariffResponse CalculateDelivery(TariffRequest request) =>
            Get<TariffResponse>("v2/calculate/delivery", "json", request);

        /// <summary>
        /// Calculates the tariff and delivery terms and returns as formatted text.
        /// Расчет тарифа и контрольных сроков доставки в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="format">Tariff response format.</param>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public string Calculate(ResponseFormat format, TariffRequest request) =>
            Get<string>("v2/calculate/tariff/delivery", GetFormat(format), request);

        /// <summary>
        /// Calculates the tariff and returns as formatted text.
        /// Расчет тарифа в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="format">Tariff response format.</param>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public string CalculateTariff(ResponseFormat format, TariffRequest request) =>
            Get<string>("v2/calculate/tariff", GetFormat(format), request);

        /// <summary>
        /// Calculates the delivery terms and returns as formatted text.
        /// Расчет контрольных сроков доставки в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 1.1)
        /// </summary>
        /// <param name="format">Tariff response format.</param>
        /// <param name="request">Tariff calculation request.</param>
        /// <returns>Calculated tariff in the requested format.</returns>
        public string CalculateDelivery(ResponseFormat format, TariffRequest request) =>
            Get<string>("v2/calculate/delivery", GetFormat(format), request);

        /// <summary>
        /// Get tariff calculation object categories as object tree.
        /// Получение списка категорий объектов расчета в виде дерева объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.1)
        /// </summary>
        public CategoryInfoResponse GetCategories() =>
            Get<CategoryInfoResponse>("v2/dictionary/category", r => r
                .AddQueryParameter("json", "json"));

        /// <summary>
        /// Get tariff calculation object categories as formatted text.
        /// Получение списка категорий объектов расчета в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.1)
        /// </summary>
        /// <param name="format">Output format.</param>
        public string GetCategories(ResponseFormat format) =>
            Get<string>("v2/dictionary/category", r => r
                .AddQueryParameter(GetFormat(format), string.Empty));

        /// <summary>
        /// Get tariff calculation object category description.
        /// Получение описания категории объектов расчета.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.2)
        /// </summary>
        /// <param name="id">Category identity.</param>
        public CategoryDescription GetCategoryDescription(int id) =>
            Get<CategoryDescription>("v2/dictionary/category", r => r
                .AddQueryParameter("json", "json")
                .AddQueryParameter("id", id.ToString()));

        /// <summary>
        /// Get tariff calculation object category description.
        /// Получение описания категории объектов расчета в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.2)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="id">Category identity.</param>
        public string GetCategoryDescription(ResponseFormat format, int id) =>
            Get<string>("v2/dictionary/category", r => r
                .AddQueryParameter(GetFormat(format), string.Empty)
                .AddQueryParameter("id", id.ToString()));

        /// <summary>
        /// Get tariff calculation object category description.
        /// Получение описания категории объектов расчета.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.4)
        /// </summary>
        /// <param name="categoryId">Category identity.</param>
        /// <param name="date">Actual date.</param>
        public CategoryObjectTypes GetObjectTypes(int categoryId, DateTime? date = null) =>
            Get<CategoryObjectTypes>("v2/dictionary/object/tariff/delivery", rqst =>
            {
                rqst.AddQueryParameter("json", "json")
                    .AddQueryParameter("id", categoryId.ToString());

                if (date.HasValue)
                {
                    rqst.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });

        /// <summary>
        /// Get tariff calculation object category description.
        /// Получение описания категории объектов расчета в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.4)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="categoryId">Category identity.</param>
        /// <param name="date">Actual date.</param>
        public string GetObjectTypes(ResponseFormat format, int categoryId, DateTime? date = null) =>
            Get<string>("v2/dictionary/object/tariff/delivery", rqst =>
            {
                var fmt = GetFormat(format);
                rqst.AddQueryParameter(fmt, fmt)
                    .AddQueryParameter("id", categoryId.ToString());

                if (date.HasValue)
                {
                    rqst.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });

        /// <summary>
        /// Get tariff calculation object description.
        /// Получение описания объекта расчета.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.4)
        /// </summary>
        /// <param name="objectType">Object type.</param>
        /// <param name="date">Actual date.</param>
        public ObjectTypeInfo GetObjectType(ObjectType objectType, DateTime? date = null)
        {
            var objectTypes = GetObjectTypes((int)objectType, date).ObjectTypes;
            var objectTypeInfo = (objectTypes ?? Enumerable.Empty<ObjectTypeInfo>()).FirstOrDefault();
            return objectTypeInfo ?? throw new TariffException("Object type not found: " + objectType, null);
        }

        /// <summary>
        /// Get tariff calculation object description.
        /// Получение описания объекта расчета в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.4)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="objectType">Object type.</param>
        /// <param name="date">Actual date.</param>
        public string GetObjectType(ResponseFormat format, ObjectType objectType, DateTime? date = null) =>
            GetObjectTypes(format, (int)objectType, date);

        /// <summary>
        /// Get services.
        /// Получение списка услуг.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.6)
        /// </summary>
        /// <param name="serviceTypes">Service types, optional.</param>
        public ServiceResponse GetServices(params ServiceType[] serviceTypes) =>
            Get<ServiceResponse>("v2/dictionary/service", r =>
            {
                r.AddQueryParameter("json", "json");

                if (serviceTypes != null && serviceTypes.Any())
                {
                    r.AddQueryString(new
                    {
                        id = serviceTypes
                    });
                }
            });

        /// <summary>
        /// Get services as text.
        /// Получение списка услуг в текстовом виде.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.6)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="serviceTypes">Service types, optional.</param>
        public string GetServices(ResponseFormat format, params ServiceType[] serviceTypes) =>
            Get<string>("v2/dictionary/service", r =>
            {
                var fmt = GetFormat(format);
                r.AddQueryParameter(fmt, fmt);

                if (serviceTypes != null && serviceTypes.Any())
                {
                    r.AddQueryString(new
                    {
                        id = serviceTypes
                    });
                }
            });

        /// <summary>
        /// Get countries as object array.
        /// Получение списка стран в виде массива объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.7)
        /// </summary>
        /// <param name="ids">Country identities.</param>
        public CountriesResponse GetCountries(params int[] ids) => GetCountries(null, ids);

        /// <summary>
        /// Get countries as object array.
        /// Получение списка стран в виде массива объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.7)
        /// </summary>
        /// <param name="date">Actual date.</param>
        /// <param name="ids">Country identities.</param>
        public CountriesResponse GetCountries(DateTime? date, params int[] ids) =>
            Get<CountriesResponse>("v2/dictionary/country{ids}", r =>
            {
                r.AddQueryParameter("json", "json");
                r.AddUrlSegment("ids", ids != null && ids.Any() ? "/" + string.Join(",", ids) : string.Empty);
                if (date.HasValue)
                {
                    r.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });

        /// <summary>
        /// Get countries as formatted text.
        /// Получение списка стран в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.7)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="ids">Country identities.</param>
        public string GetCountries(ResponseFormat format, params int[] ids) => GetCountries(format, null, ids);

        /// <summary>
        /// Get countries as formatted text.
        /// Получение списка стран в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.7)
        /// </summary>
        /// <param name="format">Output format.</param>
        /// <param name="date">Actual date.</param>
        /// <param name="ids">Country identities.</param>
        public string GetCountries(ResponseFormat format, DateTime? date = null, params int[] ids) =>
            Get<string>("v2/dictionary/country{ids}", r =>
            {
                r.AddQueryParameter(GetFormat(format), string.Empty);
                r.AddUrlSegment("ids", ids != null && ids.Any() ? "/" + string.Join(",", ids) : string.Empty);
                if (date.HasValue)
                {
                    r.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });

        /// <summary>
        /// Get post offices as object array.
        /// Получение списка почтовых отделений в виде массива объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.8)
        /// </summary>
        /// <param name="ids">Postal codes.</param>
        public PostOfficesResponse GetPostOffices(params int[] ids) => GetPostOffices(null, ids);

        /// <summary>
        /// Get post offices as object array.
        /// Получение списка почтовых отделений в виде массива объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.8)
        /// </summary>
        /// <param name="date">Actual date.</param>
        /// <param name="ids">Postal codes.</param>
        public PostOfficesResponse GetPostOffices(DateTime? date, params int[] ids) =>
            Get<PostOfficesResponse>("v2/dictionary/postoffice", r =>
            {
                r.AddQueryParameter("json", "json");

                if (ids != null && ids.Any())
                {
                    r.AddQueryParameter("id", string.Join(",", ids));
                }

                if (date.HasValue)
                {
                    r.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });

        /// <summary>
        /// Get post offices as formatted text.
        /// Получение списка почтовых отделений в виде форматированного текста.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.8)
        /// </summary>
        /// <param name="format">Response format.</param>
        /// <param name="ids">Postal codes.</param>
        public string GetPostOffices(ResponseFormat format, params int[] ids) => GetPostOffices(format, null, ids);

        /// <summary>
        /// Get post offices as object array.
        /// Получение списка почтовых отделений в виде массива объектов.
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.8)
        /// </summary>
        /// <param name="format">Response format.</param>
        /// <param name="date">Actual date.</param>
        /// <param name="ids">Postal codes.</param>
        public string GetPostOffices(ResponseFormat format, DateTime? date, params int[] ids) =>
            Get<string>("v2/dictionary/postoffice", r =>
            {
                var fmt = GetFormat(format);
                r.AddQueryParameter(fmt, fmt);

                if (ids != null && ids.Any())
                {
                    r.AddQueryParameter("id", string.Join(",", ids));
                }

                if (date.HasValue)
                {
                    r.AddQueryParameter("date", date.Value.ToString("yyyyMMdd"));
                }
            });
    }
}
