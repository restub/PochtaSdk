using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Postal office.
    /// Почтовое отделение.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 1.5)
    /// </summary>
    [DataContract]
    public class PostOffice
    {
        /// <summary>
        /// Postal code.
        /// Почтовый индекс отделения.
        /// </summary>
        [DataMember(Name = "index")]
        public int PostCode { get; set; }

        /// <summary>
        /// Post office role.
        /// Роль почтового отделения в расчете.
        /// </summary>
        [DataMember(Name = "tp")]
        public PostOfficeRole Role { get; set; }

        /// <summary>
        /// Name.
        /// Наименование.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// PS object type.
        /// Тип объекта ПС.
        /// </summary>
        [DataMember(Name = "type")]
        public int Type { get; set; }

        /// <summary>
        /// Postal code type.
        /// Тип почтового индекса.
        /// </summary>
        [DataMember(Name = "typei")]
        public int TypeI { get; set; }

        [DataMember(Name = "regionid")]
        public int RegionID { get; set; }

        [DataMember(Name = "regiono")]
        public long Regiono { get; set; }

        [DataMember(Name = "region-main")]
        public int RegionMain { get; set; }

        [DataMember(Name = "area-main")]
        public int AreaMain { get; set; }

        [DataMember(Name = "placeid")]
        public int PlaceID { get; set; }

        [DataMember(Name = "placeo")]
        public long Placeo { get; set; }

        [DataMember(Name = "parent")]
        public int Parent { get; set; }

        [DataMember(Name = "root")]
        public int Root { get; set; }

        [DataMember(Name = "courier")]
        public int Courier { get; set; }

        [DataMember(Name = "pvz")]
        public int Pvz { get; set; }

        [DataMember(Name = "item-check-view")]
        public int ItemCheckView { get; set; }

        [DataMember(Name = "move")]
        public int Move { get; set; }

        [DataMember(Name = "weight-max")]
        public int WeightMax { get; set; }

        [DataMember(Name = "pack-max")]
        public int PackMax { get; set; }

        [DataMember(Name = "box")]
        public int Box { get; set; }
    }
}
