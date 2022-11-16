using System;
using System.Linq;
using PochtaSdk.Otpravka;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to data processing.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// API request limit.
        /// Запрос текущих лимитов вызовов API.
        /// https://otpravka.pochta.ru/specification#/nogroup-count_request_api
        /// </summary>
        /// <returns>Request limits.</returns>
        public ApiLimit GetApiLimit() => Get<ApiLimit>("1.0/settings/limit");

        /// <summary>
        /// Address normalization.
        /// Нормализация адреса.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
        /// </summary>
        /// <param name="address">Address to normalize.</param>
        /// <returns>Normalized address.</returns>
        public AddressClean CleanAddress(string address) =>
            CleanAddress(new[] { address }).Single();

        /// <summary>
        /// Address normalization, batch mode.
        /// Нормализация адресов, пакетный режим.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
        /// </summary>
        /// <param name="addresses">Addresses to normalize.</param>
        /// <returns>Normalized addresses, in the same order.</returns>
        public AddressClean[] CleanAddress(params string[] addresses)
        {
            var req = addresses.Select((a, i) => new AddressRequest
            {
                ID = i.ToString(),
                OriginalAddress = a,
            });

            var result = Post<AddressClean[]>("1.0/clean/address", req.ToArray());

            // make sure that normalized addresses are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }

        /// <summary>
        /// Person full name normalization.
        /// Нормализация ФИО.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
        /// </summary>
        /// <param name="fullName">Full name to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public FullName CleanFullName(string fullName) =>
            CleanFullName(new[] { fullName }).Single();

        /// <summary>
        /// Person full name normalization.
        /// Нормализация ФИО.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
        /// </summary>
        /// <param name="fullNames">Full names to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public FullName[] CleanFullName(params string[] fullNames)
        {
            var req = fullNames.Select((a, i) => new FullNameRequest
            {
                ID = i.ToString(),
                OriginalFullName = a,
            });

            var result = Post<FullName[]>("1.0/clean/physical", req.ToArray());

            // make sure that normalized names are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }

        /// <summary>
        /// Phone number normalization.
        /// Нормализация номера телефона.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phone">Phone number to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public Phone CleanPhone(string phone) =>
            CleanPhone(new[] { phone }).Single();

        /// <summary>
        /// Phone number normalization.
        /// Нормализация номера телефона.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phones">Phone numbersto normalize.</param>
        /// <returns>Normalized phone numbers in the same order.</returns>
        public Phone[] CleanPhone(params string[] phones)
        {
            var req = phones.Select((a, i) => new PhoneRequest
            {
                ID = i.ToString(),
                OriginalPhone = a,
            });

            var result = Post<Phone[]>("1.0/clean/phone", req.ToArray());

            // make sure that normalized phones are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }

        /// <summary>
        /// Phone number normalization.
        /// Нормализация номера телефона.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phone">Phone number to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public Phone CleanPhone(PhoneRequest phone) =>
            CleanPhone(new[] { phone }).Single();

        /// <summary>
        /// Phone number normalization.
        /// Нормализация номера телефона.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phones">Phone numbersto normalize.</param>
        /// <returns>Normalized phone numbers in the same order.</returns>
        public Phone[] CleanPhone(params PhoneRequest[] phones)
        {
            var divider = ":";
            var req = phones.Select((a, i) => new PhoneRequest
            {
                ID = i.ToString() + divider + a.ID,
                Area = a.Area,
                Place = a.Place,
                Region = a.Region,
                OriginalPhone = a.OriginalPhone,
            });

            var result = Post<Phone[]>("1.0/clean/phone", req.ToArray());

            // make sure that normalized phones are returned in the same order
            // keep the original identities
            return result
                .Select(phone => new
                {
                    phone,
                    id = phone.ID.Substring(0, phone.ID.IndexOf(divider)),
                    originalId = phone.ID.Substring(phone.ID.IndexOf(divider) + 1)
                })
                .OrderBy(a => Convert.ToInt32(a.id))
                .Select(a =>
                {
                    a.phone.ID = a.originalId;
                    return a.phone;
                })
                .ToArray();
        }

        /// <summary>
        /// Shipping rate calculation.
        /// Расчет стоимости доставки
        /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
        /// </summary>
        /// <param name="request">Shipping request.</param>
        /// <returns>Request limits.</returns>
        public ShippingRateResponse CalculateShipping(ShippingRateRequest request) =>
            Post<ShippingRateResponse>("1.0/tariff", request);

        /// <summary>
        /// Get current user's shipping points.
        /// Возвращает текущие точки сдачи пользователя.
        /// https://otpravka.pochta.ru/specification#/settings-shipping_points
        /// </summary>
        /// <returns>Shipping points.</returns>
        public ShippingPoint[] GetShippingPoints() =>
            Get<ShippingPoint[]>("1.0/user-shipping-points");
    }
}
