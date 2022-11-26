using System;
using System.Linq;
using PochtaSdk.Otpravka;
using PochtaSdk.Tariff;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. Helper methods related to tariff calculation.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Shipping rate calculation.
        /// Расчет стоимости доставки
        /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
        /// </summary>
        /// <param name="request">Shipping request.</param>
        /// <returns>Shipping response.</returns>
        public ShippingRateResponse CalculateShipping(ShippingRateRequest request) =>
            Post<ShippingRateResponse>("1.0/tariff", request);

        private TariffClient tariffClient;
        private TariffClient TariffClient
        {
            get
            {
                // перенаправим трассировку тарификатора туда же, куда нашу
                tariffClient = tariffClient ?? new TariffClient();
                tariffClient.Tracer = Tracer;
                return tariffClient;
            }
        }

        /// <summary>
        /// Extended shipping rate calculation. Combines otpravka and tariff APIs.
        /// Расширенный расчет стоимости доставки. Комбинирует ответы API отправки и тарификатора.
        /// </summary>
        /// <param name="request">Shipping request.</param>
        /// <returns>Combined shipping response with improved delivery terms and error messages.</returns>
        public ShippingRateResponse CalculateShippingTariff(ShippingRateRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Request is not specified.");
            }

            // подготовим запрос для тарификатора
            var treq = request.GetTariffRequest();
            TariffResponse tariffResponse;
            string tariffError = null;

            try
            {
                // запросим расчет тарифа через тарификатор
                tariffResponse = TariffClient.Calculate(treq);
            }
            catch (Exception ex)
            {
                // сообщения об ошибках тарификатора
                // значительно более подробные, чем у отправки
                tariffError = ex.Message;
                tariffResponse = null;
            }

            int? coalesce(params int?[] values) =>
                values.FirstOrDefault(v => v.HasValue);

            // запросим через API отправки
            try
            {
                // отправка не всегда сообщает контрольные сроки доставки,
                // а тарификатор почти всегда более или менее сообщает
                var response = CalculateShipping(request);
                var minDays = coalesce(response.DeliveryTime?.MinDays, tariffResponse?.DeliveryTerms?.Min);
                var maxDays = coalesce(response.DeliveryTime?.MaxDays, tariffResponse?.DeliveryTerms?.Max);
                response.DeliveryTime = response.DeliveryTime ?? new ShippingDeliveryTime();
                response.DeliveryTime.MinDays = minDays ?? 0;
                response.DeliveryTime.MaxDays = maxDays ?? 0;
                return response;
            }
            catch (OtpravkaException ex)
            {
                // дополним сообщение об ошибке текстом из тарификатора,
                // т.к. API отправка почти всегда вернет шаблонный ответ
                var message = ex.Message;
                if (!string.IsNullOrWhiteSpace(tariffError))
                {
                    message = message.Trim().TrimEnd('.') + ". " + tariffError;
                }

                throw new OtpravkaException(ex.StatusCode, message, ex);
            }
        }
    }
}
