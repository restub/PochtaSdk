using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using PochtaSdk.Toolbox;
using Restub.DataContracts;
using Restub.Toolbox;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Return creation response.
    /// Ответ метода создания возвратов.
    /// https://otpravka.pochta.ru/specification#/returns-create_for_direct
    /// </summary>
    [DataContract]
    public class ReturnResponse : IHasErrors
    {
        /// <summary>
        /// Штрих-код созданного возврата
        /// </summary>
        [DataMember(Name = "return-barcode")]
        public string ReturnBarcode { get; set; }

        /// <summary>
        /// Индекс в исходном массиве
        /// </summary>
        [DataMember(Name = "position")]
        public int Position { get; set; }

        /// <summary>
        /// Список ошибок
        /// </summary>
        [DataMember(Name = "errors")]
        public Error[] Errors { get; set; }

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
                        Description = err.ErrorCode.Value.GetDisplayName(),
                    };

                return errorsWithCodes.Concat(moreErrors);
            }
        }

        /// <inheritdoc/>
        public bool HasErrors() => ErrorsWithCodes.Any();

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            string.Join(". ", ErrorsWithCodes
                .Select(e => e.Description.Coalesce(e.Code.GetDisplayName(), string.Empty)
                    .Trim(". \r\n\v".ToCharArray())));
    }
}
