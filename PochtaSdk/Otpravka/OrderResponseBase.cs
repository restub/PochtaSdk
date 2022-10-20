using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Restub.DataContracts;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order creation response base (API v1.0).
    /// Ответ метода создания или удаления заказов (API v1.0).
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/orders-delete_new_order
    /// </summary>
    [DataContract]
    public class OrderResponseBase : IHasErrors
    {
        /// <summary>
        /// Список ошибок
        /// </summary>
        [DataMember(Name = "errors")]
        public Error[] Errors { get; set; }

        /// <summary>
        /// Список кодов заказов
        /// </summary>
        [DataMember(Name = "result-ids")] // v1.0
        public long[] ResultIDs { get; set; }

        private IEnumerable<ErrorWithCode> ErrorsWithCodes
        {
            get
            {
                var errors = Errors ?? Enumerable.Empty<Error>();

                // sometimes we have errors holding arrays or error-with-codes
                var errorsWithCodes =
                    from err in errors
                    orderby err.Position
                    from ewc in err.ErrorCodes ?? Enumerable.Empty<ErrorWithCode>()
                    orderby ewc.Position
                    select ewc;

                // and sometimes we have flat errors with error-codes
                var moreErrors =
                    from err in errors
                    orderby err.Position
                    where err.ErrorCode.HasValue
                    select new ErrorWithCode
                    {
                        Code = err.ErrorCode.Value,
                        Description = err.ErrorCode.ToString(),
                    };

                return errorsWithCodes.Concat(moreErrors);
            }
        }

        /// <summary>
        /// В ответе есть коды заказов
        /// </summary>
        protected virtual bool HasOrders => ResultIDs != null && ResultIDs.Any();

        /// <inheritdoc/>
        public bool HasErrors() => !HasOrders && ErrorsWithCodes.Any();

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            string.Join(". ", ErrorsWithCodes
                .Select(e => (e.Description + string.Empty)
                    .Trim(". \r\n\v".ToCharArray())));
    }
}
