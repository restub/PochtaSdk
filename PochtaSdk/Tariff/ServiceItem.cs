using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariff calculation service item.
    /// Информация об услугах, включенных в расчет тарифа.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.4)
    /// </summary>
    [DataContract]
    public class ServiceItem
    {
        /// <summary>
        /// Calculation step identity. The value is not persistent,
        /// so for any practical purpose is basically useless.
        /// Код шага расчета. Не является постоянной величиной, 
        /// изменяется со временем у одного и того же объекта.
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Calculation step name.
        /// Наименование шага расчета.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Service types included in the current step of the tariff calculation.
        /// Список кодов дополнительных услуг, вариантов расчета и указателей, 
        /// которые используются на шаге расчета.
        /// </summary>
        [DataMember(Name = "serviceon")]
        public ServiceType[] ServiceOn { get; set; }

        /// <summary>
        /// Service types that cancel the current step in the tariff calculation.
        /// Коды услуг, применение которых отменяет шаг расчета.
        /// </summary>
        [DataMember(Name = "serviceoff")]
        public ServiceType[] ServiceOff { get; set; }

        /// <summary>
        /// Source postal code.
        /// Индекс места отправления.
        /// </summary>
        [DataMember(Name = "from")]
        public int FromPostCode { get; set; }

        /// <summary>
        /// Destination postal code.
        /// Индекс места назначения.
        /// </summary>
        [DataMember(Name = "to")]
        public int ToPostCode { get; set; }

        /// <summary>
        /// Calculated tariff.
        /// Тариф на шаге расчета.
        /// </summary>
        [DataMember(Name = "tariff")]
        public TariffAmount Tariff { get; set; }

        [DataMember(Name = "delivery")]
        public DeliveryTerms Delivery { get; set; }
    }
}
