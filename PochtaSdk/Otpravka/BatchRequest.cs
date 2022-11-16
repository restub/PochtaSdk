using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Restub.Toolbox;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch creation request.
    /// Запрос метода создания партий.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class BatchRequest
    {
        /// <summary>
        /// Дата сдачи в почтовое отделение (yyyy-MM-dd), опционально
        /// </summary>
        ///[DataMember(Name = "sending-date"), JsonConverter(typeof(DateOnlyConverter))]
        [IgnoreDataMember]
        public DateTime? SendingDate { get; set; }

        /// <summary>
        /// Смещение даты сдачи от UTC в секундах, опционально
        /// </summary>
        [DataMember(Name = "timezone-offset")]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// Признак использования онлайн баланса
        /// </summary>
        [DataMember(Name = "use-online-balance")]
        public bool? UseOnlineBalance { get; set; }

        /// <summary>
        /// Список заказов
        /// </summary>
        [IgnoreDataMember]
        public long[] OrderIDs { get; set; }
    }
}
