using Newtonsoft.Json.Converters;

namespace PochtaSdk.Toolbox
{
    public class TariffDateTimeConverter : IsoDateTimeConverter
    {
        public TariffDateTimeConverter()
        {
            DateTimeFormat = "yyyyMMdd\\THHmmss";
        }
    }
}
