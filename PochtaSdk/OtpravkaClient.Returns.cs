using System.Linq;
using PochtaSdk.Otpravka;

namespace PochtaSdk
{
    /// <remarks>
    /// Pochta.ru Otpravka API client. REST API methods related to returns.
    /// https://otpravka.pochta.ru/specification
    /// </remarks>
    public partial class OtpravkaClient
    {
        /// <summary>
        /// Create return.
        /// Создание возврата для ШПИ указанного отправления.
        /// https://otpravka.pochta.ru/specification#/returns-create_for_direct
        /// </summary>
        /// <returns>Return information.</returns>
        public ReturnResponse CreateReturn(ReturnDirect ret) =>
            Put<ReturnResponse>("1.0/returns", ret);

        /// <summary>
        /// Create return.
        /// Создание возврата для ШПИ указанного отправления.
        /// https://otpravka.pochta.ru/specification#/returns-create_for_direct
        /// </summary>
        /// <returns>Return information.</returns>
        public ReturnResponse CreateReturn(string barcode, MailType mailType = MailType.Undefined) =>
            Put<ReturnResponse>("1.0/returns", new ReturnDirect
            {
                DirectBarcode = barcode,
                MailType = mailType,
            });

        /// <summary>
        /// Create separate return order.
        /// Создание отдельного возвратного отправления.
        /// https://otpravka.pochta.ru/specification#/returns-create_without_direct
        /// </summary>
        /// <returns>Return information.</returns>
        public ReturnResponse[] CreateReturns(params ReturnOrder[] returns) =>
            Put<ReturnResponse[]>("1.0/returns/return-without-direct", returns);

        /// <summary>
        /// Create separate return order.
        /// Создание отдельного возвратного отправления.
        /// https://otpravka.pochta.ru/specification#/returns-create_without_direct
        /// </summary>
        /// <returns>Return information.</returns>
        public ReturnResponse CreateReturn(ReturnOrder ret) =>
            CreateReturns(ret).Single();

        /// <summary>
        /// Update separate return order.
        /// Изменение отдельного возвратного отправления.
        /// https://otpravka.pochta.ru/specification#/returns-update_separate_return
        /// </summary>
        /// <returns>Error information.</returns>
        public ReturnResponse UpdateReturn(string barcode, ReturnOrder ret) =>
            Put<ReturnResponse>("1.0/returns/{barcode}", ret, r =>
                r.AddUrlSegment("barcode", barcode));

        /// <summary>
        /// Delete separate return.
        /// Удаление отдельного возврата.
        /// https://otpravka.pochta.ru/specification#/returns-delete_separate_return
        /// </summary>
        /// <returns>Return information.</returns>
        public ErrorWithCode DeleteReturn(string barcode) =>
            Delete<ErrorWithCode>("1.0/returns/delete-separate-return", null, r =>
                r.AddQueryParameter("barcode", barcode));
    }
}
