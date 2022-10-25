using System;
using PochtaSdk.Otpravka;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to post offices.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Get post office by postal code.
        /// Получить информацию об ОПС по индексу.
        /// https://otpravka.pochta.ru/specification#/services-postoffice
        /// </summary>
        /// <param name="postalCode">Postal code.</param>
        /// <returns>Post office information.</returns>
        public PostOffice GetPostOffice(string postalCode) =>
            GetPostOffice(new PostOfficeRequest
            {
                PostalCode = postalCode,
            });

        /// <summary>
        /// Get post office by postal code.
        /// Получить информацию об ОПС по индексу.
        /// https://otpravka.pochta.ru/specification#/services-postoffice
        /// </summary>
        /// <param name="request">Search request.</param>
        /// <returns>Post office information.</returns>
        public PostOffice GetPostOffice(PostOfficeRequest request) =>
            Get<PostOffice>("postoffice/1.0/{postal-code}", r => r
                .AddUrlSegment("postal-code", request.PostalCode)
                .AddQueryString(request));

        /// <summary>
        /// Get post office services by postal code.
        /// Получить информацию о сервисах ОПС по индексу.
        /// https://otpravka.pochta.ru/specification#/services-postoffice-service
        /// </summary>
        /// <param name="postalCode">Postal code.</param>
        /// <returns>Post office service information.</returns>
        public PostOfficeService[] GetPostOfficeServices(string postalCode) =>
            Get<PostOfficeService[]>("postoffice/1.0/{postal-code}/services", r => r
                .AddUrlSegment("postal-code", postalCode));

        /// <summary>
        /// Get post office services by postal code and service group code.
        /// Получить информацию о сервисах ОПС по индексу и коду группы.
        /// https://otpravka.pochta.ru/specification#/services-postoffice-service-group
        /// </summary>
        /// <param name="postalCode">Postal code.</param>
        /// <param name="serviceGroupId">Service group identity.</param>
        /// <returns>Post office service information.</returns>
        public PostOfficeService[] GetPostOfficeServices(string postalCode, int serviceGroupId) =>
            Get<PostOfficeService[]>("postoffice/1.0/{postal-code}/services/{service-group-id}", r => r
                .AddUrlSegment("postal-code", postalCode)
                .AddUrlSegment("service-group-id", serviceGroupId));

        /// <summary>
        /// Search post offices by address.
        /// Поиск обслуживающего ОПС по адресу.
        /// https://otpravka.pochta.ru/specification#/services-postoffice-by-address
        /// </summary>
        /// <param name="address">Address to search for.</param>
        /// <param name="top">Return top results, default is 3.</param>
        /// <returns>Matching post office codes.</returns>
        public PostOfficeResponse SearchPostOffices(string address, int? top = null) =>
            Get<PostOfficeResponse>("postoffice/1.0/by-address", r => r.AddQueryString(new { address, top }));
    }
}
