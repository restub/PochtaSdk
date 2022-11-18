using System.Linq;
using System.Threading.Tasks;
using PochtaSdk.Tracking;
using PochtaSdk.Tracking.BatchRequest;
using PochtaSdk.Tracking.SingleRequest;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru mail tracking client. Doesn't support debug tracing.
    /// Клиент трекинга pochta.ru. Не поддерживает отладочную трассировку.
    /// https://tracking.pochta.ru/
    /// </summary>
    public class TrackingClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingClient"/> class.
        /// </summary>
        /// <param name="userName">User name.</param>
        /// <param name="password">Password</param>
        public TrackingClient(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        private string UserName { get; }

        private string Password { get; }

        private OperationHistory12Client SingleRequestClient { get; } = new OperationHistory12Client();

        // currently not used
        //private FederalClientClient BatchRequestClient { get; } = new FederalClientClient();

        /// <summary>
        /// Gets operation history for the given tracking barcode.
        /// Возвращает историю операций для указанного ШПИ, или, опционально, для заказного уведомления о вручении этого ШПИ.
        /// https://tracking.pochta.ru/specification#getOperationHistory
        /// </summary>
        /// <param name="barcode">Mail tracking barcode. ШПИ отправления.</param>
        /// <param name="notification">Track mail notification history. Показать историю заказного уведомления.</param>
        /// <returns>Operation history records.</returns>
        public HistoryRecord[] GetOperationHistory(string barcode, bool notification = false) =>
            GetOperationHistoryAsync(barcode, notification ? 1 : 0)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult()
                .Flatten()
                .ToArray();

        private async Task<OperationHistoryRecord[]> GetOperationHistoryAsync(string barcode, int messageType = 0)
        {
            var response = await SingleRequestClient.getOperationHistoryAsync(new getOperationHistoryRequest
            {
                AuthorizationHeader = new AuthorizationHeader
                {
                    login = UserName,
                    password = Password,
                },
                OperationHistoryRequest = new OperationHistoryRequest
                {
                    Barcode = barcode,
                    MessageType = messageType,
                },
            });

            return response.OperationHistoryData;
        }
    }
}
