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
        public ErrorWithCode[] Errors { get; set; }

        /// <inheritdoc/>
        public bool HasErrors() => Errors.Any();

        /// <inheritdoc/>
        public string GetErrorMessage() =>
            string.Join(". ", Errors
                .Select(e => e.Description.Coalesce(e.Code.GetDisplayName(), string.Empty)
                    .Trim(". \r\n\v".ToCharArray())));
    }
}
