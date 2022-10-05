using System;
using System.Linq;
using System.Runtime.CompilerServices;
using PochtaSdk.Tariff;
using Restub;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru tariffication API client, requires no authentication.
    /// Клиент сервиса тарификации pochta.ru, аутентификация не требуется.
    /// https://tariff.pochta.ru/
    /// </summary>
    public class TariffClient : RestubClient
    {
        public const string BaseUrl = "https://tariff.pochta.ru/";

        /// <summary>
        /// Initializes a new instance of the <see cref="TariffClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base URL of the tariffication API.</param>
        public TariffClient(string baseUrl = BaseUrl) : base(baseUrl)
        {
        }

        public override string LibraryName =>
            $"{nameof(PochtaSdk)}.{nameof(TariffClient)} v{GetType().GetAssemblyVersion()}, {base.LibraryName}";

        private string GetFormat(ResponseFormat format) =>
            ParameterHelper.GetEnumMemberValue(format) as string;

        private T Get<T>(string url, string format, TariffRequest request, [CallerMemberName] string apiMethodName = null) =>
            Get<T>(url, r =>
            {
                // add properties with easy formatting
                r.AddQueryParameter(format, format)
                    .AddQueryString(request);

                // add properties with weird formatting
                if (request.ErrorCode.HasValue)
                {
                    r.AddQueryParameter("errorcode",
                        request.ErrorCode.Value ? "1" : "0");
                }

                if (request.Closed.HasValue)
                {
                    r.AddQueryParameter("closed",
                        request.Closed.Value ? "1" : "0");
                }

                if (request.Date.HasValue)
                {
                    r.AddQueryParameter("date",
                        request.Date.Value.ToString("yyyyMMdd"));
                }

                if (request.Time.HasValue)
                {
                    r.AddQueryParameter("time",
                        request.Time.Value.ToString("hhmm"));
                }
            }, apiMethodName);

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
        public CategoryInfo GetCategories() =>
            Get<CategoryInfo>("v2/dictionary/category", r => r
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
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.2)
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
        /// https://tariff.pochta.ru/post-calculator-api.pdf (chapter 2.3.2)
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
    }
}
