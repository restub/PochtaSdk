using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office.
    /// Почтовое отделение.
    /// https://otpravka.pochta.ru/specification#/services-postoffice
    /// </summary>
    [DataContract]
    public class PostOffice
    {
        /// <summary>
        /// Адрес отделения
        /// </summary>
        [DataMember(Name = "address-source")]
        public string AddressSource { get; set; }

        /// <summary>
        /// Рабочие часы в текущее время
        /// </summary>
        [DataMember(Name = "current-day-working-hours")]
        public PostOfficeSchedule CurrentDayWorkingHours { get; set; }

        /// <summary>
        /// Расстояние до отделения
        /// </summary>
        [DataMember(Name = "distance")]
        public int Distance { get; set; }

        /// <summary>
        /// Округ
        /// </summary>
        [DataMember(Name = "district")]
        public string District { get; set; }

        /// <summary>
        /// Выходные
        /// </summary>
        [DataMember(Name = "holidays")]
        public PostOfficeHoliday[] Holidays { get; set; }

        /// <summary>
        /// Признак 'закрыто'
        /// </summary>
        [DataMember(Name = "is-closed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Признак внутреннего отделения
        /// </summary>
        [DataMember(Name = "is-private-category")]
        public bool IsPrivateCategory { get; set; }

        /// <summary>
        /// Признак 'временно закрыто'
        /// </summary>
        [DataMember(Name = "is-temporary-closed")]
        public bool IsTemporaryClosed { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        [DataMember(Name = "latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        [DataMember(Name = "longitude")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Индекс ближайшего почтового отделения
        /// </summary>
        [DataMember(Name = "nearest-office-postalcode")]
        public string NearestOfficePostalCode { get; set; }

        /// <summary>
        /// Ближайшее почтовое отделение
        /// </summary>
        [DataMember(Name = "nearest-postoffice")]
        public PostOffice NearestPostoffice { get; set; }

        /// <summary>
        /// Рабочие часы в следующий рабочий день
        /// </summary>
        [DataMember(Name = "next-day-working-hours")]
        public PostOfficeSchedule NextDayWorkingHours { get; set; }

        /// <summary>
        /// Телефоны
        /// </summary>
        [DataMember(Name = "phones")]
        public PostOfficePhone[] Phones { get; set; }

        /// <summary>
        /// Индекс почтового отделения
        /// </summary>
        [DataMember(Name = "postal-code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Предписанный
        /// </summary>
        [DataMember(Name = "prescribed")]
        public bool Prescribed { get; set; }

        /// <summary>
        /// Область, край
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Группы сервисов
        /// </summary>
        [DataMember(Name = "service-groups")]
        public PostOfficeServiceGroup[] ServiceGroups { get; set; }

        /// <summary>
        /// Поселение
        /// </summary>
        [DataMember(Name = "settlement")]
        public string Settlement { get; set; }

        /// <summary>
        /// Причина 'временно закрыто'
        /// </summary>
        [DataMember(Name = "temporary-closed-reason")]
        public string TemporaryClosedReason { get; set; }

        /// <summary>
        /// Тип отделения
        /// </summary>
        [DataMember(Name = "type-code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// Идентификатор типа отделения
        /// </summary>
        [DataMember(Name = "type-id")]
        public int TypeID { get; set; }

        /// <summary>
        /// Код ЮФПС
        /// </summary>
        [DataMember(Name = "ufps-code")]
        public string UfpsCode { get; set; }

        /// <summary>
        /// Рабочие часы
        /// </summary>
        [DataMember(Name = "working-hours")]
        public PostOfficeSchedule[] WorkingHours { get; set; }

        /// <summary>
        /// Признак работы в субботу
        /// </summary>
        [DataMember(Name = "works-on-saturdays")]
        public bool WorksOnSaturdays { get; set; }

        /// <summary>
        /// Признак работы в воскресенье
        /// </summary>
        [DataMember(Name = "works-on-sundays")]
        public bool WorksOnSundays { get; set; }
    }
}
