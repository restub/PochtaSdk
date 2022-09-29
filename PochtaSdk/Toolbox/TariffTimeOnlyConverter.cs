using System;
using System.Net;
using Newtonsoft.Json;
using Restub;

namespace PochtaSdk.Toolbox
{
    public class TariffTimeOnlyConverter : CustomIsoDateTimeConverter
    {
        public TariffTimeOnlyConverter()
        {
            DateTimeFormat = "hhmmss";
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (FormatException ex)
            {
                throw new RestubException(HttpStatusCode.OK, "Cannot deserialize " +
                    $"TimeSpan value of '{reader.Value}': {ex.Message}", ex);
            }
        }
    }
}
