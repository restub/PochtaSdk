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
        /// Generates F7p print form in PDF format. Shipping order should be added to a batch.
        /// Генерация печатной формы Ф7п в формате PDF. Заказ должен быть в составе партии.
        /// </summary>
        /// <param name="orderId">Order identity.</param>
        /// <param name="sendingDate">Optional sending date.</param>
        /// <param name="thermo">Thermoprinter option.</param>
        public byte[] GetPrintFormF7P(long orderId, DateTime? sendingDate = null, bool? thermo = null) =>
            Get<byte[]>("1.0/forms/{id}/f7pdf", r =>
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

        /// <summary>
        /// Generates F112EK print form in PDF format. Shipping order should be added to a batch.
        /// Генерация печатной формы Ф112ЭК в формате PDF. Заказ должен быть в составе партии.
        /// </summary>
        /// <param name="orderId">Order identity.</param>
        /// <param name="sendingDate">Optional sending date.</param>
        public byte[] GetPrintFormF112EK(long orderId, DateTime? sendingDate = null) =>
            Get<byte[]>("1.0/forms/{id}/f112pdf", r =>
            {
                r.AddUrlSegment("id", orderId).AddHeader("Accept", "application/pdf");

                if (sendingDate.HasValue)
                {
                    r.AddQueryParameter("sending-date",
                        sendingDate.Value.ToString("yyyy-MM-dd"));
                }
            });

        /// <summary>
        /// Generates order print form in PDF format. Shipping order should not be added to a batch.
        /// Генерация печатных форм для заказа в формате PDF. Заказ должен быть не в составе партии.
        /// </summary>
        /// <param name="orderId">Order identity.</param>
        /// <param name="sendingDate">Optional sending date.</param>
        public byte[] GetPrintForms(long orderId, DateTime? sendingDate = null) =>
            Get<byte[]>("1.0/forms/backlog/{id}/forms", r =>
            {
                r.AddUrlSegment("id", orderId); //.AddHeader("Accept", "application/octet-stream");

                if (sendingDate.HasValue)
                {
                    r.AddQueryParameter("sending-date",
                        sendingDate.Value.ToString("yyyy-MM-dd"));
                }
            });
    }
}
