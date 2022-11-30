using System;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to print forms.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Generates and downloads zip archive with all files related to the given batch.
        /// Генерирует и возвращает zip архив с 4-мя файлами:
        /// * Export.xls, Export.csv — список с основными данными по заявкам в составе партии
        /// * F103.pdf — форма ф103 по заявкам в составе партии
        /// * В зависимости от типа и категории отправлений, формируется комбинация 
        ///   из сопроводительных документов в формате pdf (формы: f7, f112, f22)
        /// https://otpravka.pochta.ru/specification#/documents-create_all_docs
        /// </summary>
        /// <param name="batchName">Batch name (number).</param>
        /// <param name="thermo">Use thermoprinter form templates.</param>
        /// <param name="twoSided">Two-sided print form templates.</param>
        /// <returns>Zip file contents.</returns>
        public byte[] DownloadBatchDocuments(string batchName, bool? thermo = null, bool? twoSided = null) =>
            Get<byte[]>("1.0/forms/{name}/zip-all", r =>
            {
                r.AddUrlSegment("name", batchName);
                if (thermo.HasValue)
                {
                    r.AddQueryParameter("print-type", thermo.Value ? "THERMO" : "PAPER");
                }

                if (twoSided.HasValue)
                {
                    r.AddQueryParameter("print-form-type", twoSided.Value ? "TWO_SIDED" : "ONE_SIDED");
                }
            });

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
