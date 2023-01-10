using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// ECOM options from post office passport.
    /// Опции ECOM почтового отделения из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportEcomOptions
    {
        /// <summary>
        /// Есть оплата по карте.
        /// </summary>
        [DataMember(Name = "cardPayment")]
        public bool CardPayment { get; set; }

        /// <summary>
        /// Есть оплата наличными.
        /// </summary>
        [DataMember(Name = "cashPayment")]
        public bool CashPayment { get; set; }

        /// <summary>
        /// Есть проверка вложения.
        /// </summary>
        [DataMember(Name = "contentsChecking")]
        public bool ContentsChecking { get; set; }

        /// <summary>
        /// Есть проверка функционала.
        /// </summary>
        [DataMember(Name = "functionalityChecking")]
        public bool FunctionalityChecking { get; set; }

        /// <summary>
        /// Есть частичный возврат.
        /// </summary>
        [DataMember(Name = "partialRedemption")]
        public bool PartialRedemption { get; set; }

        /// <summary>
        /// Доступен возврат.
        /// </summary>
        [DataMember(Name = "returnAvailable")]
        public bool ReturnAvailable { get; set; }

        /// <summary>
        /// Максимальный допустимый вес отправления.
        /// </summary>
        [DataMember(Name = "weightLimit")]
        public double WeightLimit { get; set; }

        /// <summary>
        /// Есть примерка.
        /// </summary>
        [DataMember(Name = "withFitting")]
        public bool WithFitting { get; set; }
    }
}
