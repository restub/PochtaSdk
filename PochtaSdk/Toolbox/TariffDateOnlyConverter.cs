using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Restub;

namespace PochtaSdk.Toolbox
{
    public class TariffDateOnlyConverter : CustomIsoDateTimeConverter
    {
        public TariffDateOnlyConverter()
        {
            DateTimeFormat = "yyyyMMdd";
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
                    $"DateTime value of '{reader.Value}': {ex.Message}", ex);
            }
        }
    }
}
