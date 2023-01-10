using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office passport snapshot download.
    /// Выгрузка из паспорта ОПС.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public class PassportSnapshot
    {
        /// <summary>
        /// Список почтовых отделений.
        /// </summary>
        [DataMember(Name = "passportElements")]
        public PassportPostOffice[] PostOffices { get; set; }

        /// <summary>
        /// Дата выгрузки паспорта ОПС.
        /// </summary>
        [DataMember(Name = "unloadingDate")]
        public DateTime UnloadingDate { get; set; }

        /// <summary>
        /// Название выгрузки паспорта ОПС.
        /// </summary>
        [DataMember(Name = "vsnapshot")]
        public string Vsnapshot { get; set; }
    }
}
