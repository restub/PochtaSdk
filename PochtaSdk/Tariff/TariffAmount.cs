using System.Runtime.Serialization;

namespace PochtaSdk.Tariff
{
    [DataContract]
    public class TariffAmount
    {
        [DataMember(Name = "val")]
        public int Amount { get; set; }

        [DataMember(Name = "valnds")]
        public int AmountVat { get; set; }
    }
}
