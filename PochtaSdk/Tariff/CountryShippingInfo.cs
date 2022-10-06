using System;
using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Country shipping requisites.
    /// Информация о реквизитах отправлений в стране.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.6)
    /// </summary>
    [DataContract]
    public class CountryShippingInfo
    {
        /// <summary>
        /// Возможность доставки:
        /// 0 – доставка разрешена
        /// 1 – доставка запрещена
        /// 19 – доставка временно запрещена по COVID-19
        /// </summary>
        [DataMember(Name = "block")]
        public int Block { get; set; }

        /// <summary>
        /// Declared value shippings are allowed if the value is 1.
        /// При 1 разрешены отправления с объявленной ценностью.
        /// </summary>
        [DataMember(Name = "oc")]
        public int DeclaredValueAllowed { get; set; }

        /// <summary>
        /// Declared value shippings rate, percents.
        /// Ставка объявленной ценности, в процентах.
        /// </summary>
        [DataMember(Name = "oc-rate")]
        public decimal? DeclaredValueRate { get; set; }

        /// <summary>
        /// Additional information on declared value shippings.
        /// Дополнительная информация по объявленной ценности.
        /// </summary>
        [DataMember(Name = "oc-note")]
        public string DeclaredValueNotes { get; set; }

        /// <summary>
        /// Declared value maximal value, cents.
        /// Максимальная сумма объявленной ценности, в копейках.
        /// </summary>
        [DataMember(Name = "oc-max")]
        public int? DeclaredValueMax { get; set; }

        /// <summary>
        /// Declared value maximal value in SDR.
        /// Максимальная сумма объявленной ценности в СПЗ.
        /// </summary>
        [DataMember(Name = "oc-max-sdr")]
        public decimal? DeclaredValueMaxSdr { get; set; }

        /// <summary>
        /// Cash on delivery shippings are allowed if the value is 1.
        /// При 1 разрешены отправления с наложенным платежом.
        /// </summary>
        [DataMember(Name = "np")]
        public int? CashOnDeliveryAllowed { get; set; }

        /// <summary>
        /// Cash on delivery maximal value, cents.
        /// Предельный размер суммы наложенного платежа в копейках.
        /// </summary>
        [DataMember(Name = "np-max")]
        public int? CashOnDeliveryMax { get; set; }

        /// <summary>
        /// Cash on delivery maximal value in SDR.
        /// Предельный размер суммы наложенного платежа в СПЗ.
        /// </summary>
        [DataMember(Name = "np-max-sdr")]
        public decimal? CashOnDeliveryMaxSdr { get; set; }

        /// <summary>
        /// Maximal weight, grams.
        /// Предельная масса в граммах.
        /// </summary>
        [DataMember(Name = "wmax")]
        public int? WeightMax { get; set; }

        /// <summary>
        /// Maximal size, centimetres.
        /// Предельные размеры в сантиметрах.
        /// </summary>
        [DataMember(Name = "sizemax")]
        public SizeMax SizeMax { get; set; }

        /// <summary>
        /// Maximal linear size, centimetres.
        /// Длина по наибольшей окружности в сантиметрах.
        /// </summary>
        [DataMember(Name = "linemax")]
        public int? LineMax { get; set; }

        [DataMember(Name = "legal")]
        public int Legal { get; set; }

        [DataMember(Name = "courier")]
        public int Courier { get; set; }

        [DataMember(Name = "notification")]
        public int Notification { get; set; }

        [DataMember(Name = "personally")]
        public int Personally { get; set; }

        [DataMember(Name = "warning")]
        public int Warning { get; set; }

        [DataMember(Name = "addrcorrect")]
        public int AddrCorrect { get; set; }

        [DataMember(Name = "declaration")]
        public int Declaration { get; set; }

        [DataMember(Name = "bigsize")]
        public int BigSize { get; set; }

        [DataMember(Name = "serviceoff")]
        public ServiceType[] ServiceOff { get; set; }

        /// <summary>
        /// Avia delivery information.
        /// Значения реквизитов при авиа-доставке. В объекте
        /// присутствуют только те параметры, в которых значения при
        /// авиа-доставке отличаются от значений при наземной доставке.
        /// </summary>
        [DataMember(Name = "avia")]
        public CountryAviaInfo Avia { get; set; }
    }
}
