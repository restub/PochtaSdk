using System;
using System.Runtime.CompilerServices;
using PochtaSdk.Tariff;
using RestSharp;
using Restub;
using Restub.DataContracts;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru tariffication API client, requires no authentication.
    /// Клиент сервиса тарификации pochta.ru, аутентификация не требуется.
    /// https://tariff.pochta.ru/
    /// </summary>
    public partial class TariffClient : RestubClient
    {
        public const string BaseUrl = "https://tariff.pochta.ru/";

        /// <summary>
        /// Initializes a new instance of the <see cref="TariffClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base URL of the tariffication API.</param>
        public TariffClient(string baseUrl = BaseUrl) : base(baseUrl)
        {
        }

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse response, string errorMessage, IHasErrors errorResponse) =>
            new TariffException(response.StatusCode, errorMessage, response.ErrorException)
            {
                ErrorResponseText = response.Content,
            };

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(PochtaSdk)}.{nameof(TariffClient)} v{LibraryVersion}, {base.LibraryName}";

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
    }
}
