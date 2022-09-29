using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Packaging information.
    /// Информация о типе упаковки посылки.
    /// </summary>
    [DataContract]
    public class PackageInfo
    {
        [DataMember(Name = "id")]
        public PackageType PackageType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
