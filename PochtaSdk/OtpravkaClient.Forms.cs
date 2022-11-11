using System;
using PochtaSdk.Otpravka;
using Restub.Toolbox;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to print forms.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Generates F7P print form in PDF format. Shipping order should be added to a batch.
        /// Генерация печатной формы Ф7п в формате PDF. Заказ должен быть в составе партии.
        /// </summary>
        /// <param name="orderId">Order identity.</param>
        /// <param name="sendingDate">Optional sending date.</param>
        /// <param name="thermo">Thermoprinter option.</param>
        public byte[] GetPrintFormF7P(long orderId, DateTime? sendingDate = null, bool? thermo = false) =>
            Get<byte[]>("1.0/forms/{id}/f7pdf?print-type=THERMO", r =>
            {
                r.AddUrlSegment("id", orderId).AddHeader("Accept", "application/pdf");

                if (sendingDate.HasValue)
                {
                    r.AddQueryParameter("sending-date",
                        sendingDate.Value.ToString("yyyy-MM-dd"));
                }

                if (thermo.HasValue)
                {
                    r.AddQueryParameter("print-type",
                        thermo.Value ? "THERMO" : "PAPER");
                }
            });
    }
}
