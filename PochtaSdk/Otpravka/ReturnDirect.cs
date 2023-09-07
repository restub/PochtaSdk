using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Return, direct version.
    /// Возврат прямого отправления.
    /// https://otpravka.pochta.ru/specification#/returns-create_for_direct
    /// </summary>
    [DataContract]
    public class ReturnDirect
    {
        /// <summary>
        /// ШПИ прямого отправления
        /// </summary>
        [DataMember(Name = "direct-barcode")]
        public string DirectBarcode { get; set; }

        /// <summary>
        /// Вид РПО
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

    }
}
