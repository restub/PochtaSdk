using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Document download status.
    /// Статус необходимости скачивания новых документов.
    /// https://otpravka.pochta.ru/specification#/enums-document-download-status
    /// </summary>
    [DataContract]
    public enum DocumentDownloadStatus
    {
        /// <summary>
        /// Ф103 изменена
        /// </summary>
        [EnumMember(Value = "F103")]
        F103,

        /// <summary>
        /// Ф103 и ярлыки со знаком онлайн-оплаты изменены
        /// </summary>
        [EnumMember(Value = "F103_AND_OPM")]
        F103AndOpm,

        /// <summary>
        /// Ф103 изменена и есть новые отправления
        /// </summary>
        [EnumMember(Value = "F103_AND_NEW_SHIPMENT")]
        F103AndNewShipment,

        /// <summary>
        /// Изменена транспортная накладная
        /// </summary>
        [EnumMember(Value = "TRANSPORT_BLANK")]
        TransportBlank,

        /// <summary>
        /// Изменена транспортная накладная и ярлыки со знаком онлайн-оплаты
        /// </summary>
        [EnumMember(Value = "TRANSPORT_BLANK_AND_OPM")]
        TransportBlankAndOpm,

        /// <summary>
        /// Изменена транспортная накладная и есть новые отправления
        /// </summary>
        [EnumMember(Value = "TRANSPORT_BLANK_AND_NEW_SHIPMENT")]
        TransportBlankAndNewShipment,
    }
}