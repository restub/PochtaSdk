using System.Threading.Tasks;
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

        private FederalClientClient BatchRequestClient { get; } = new FederalClientClient();

        /// <summary>
        /// Gets operation history for the given tracking barcode.
        /// </summary>
        /// <param name="barcode">Mail tracking barcode.</param>
        /// <returns>Operation history records.</returns>
        public OperationHistoryRecord[] GetOperationHistory(string barcode) =>
            GetOperationHistoryAsync(barcode, 0).ConfigureAwait(false).GetAwaiter().GetResult();

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
