using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Restub.Toolbox;

namespace PochtaSdk.Toolbox
{
    public class CustomIsoDateTimeConverter : IsoDateTimeConverter
    {
        //###
        public TimeSpanStyles TimeSpanStyles { get; set; } = TimeSpanStyles.None;

        /// <summary>
        /// Reads the JSON representation of the object.
        /// Copied from the base class, added support for the integer representation.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var nullable = objectType.IsNullable();
            if (reader.TokenType == JsonToken.Null)
            {
                if (!nullable)
                {
                    throw new JsonSerializationException(string.Format(CultureInfo.InvariantCulture, "Cannot convert null value to {0}.", objectType));
                }

                return null;
            }

            // real type expected by the caller
            Type t = nullable
                ? ParameterHelper.GetNonNullableType(objectType)
                : objectType;

            if (reader.TokenType == JsonToken.Date)
            {
                if (t == typeof(DateTimeOffset))
                {
                    return (reader.Value is DateTimeOffset) ? reader.Value : new DateTimeOffset((DateTime)reader.Value);
                }

                //###
                if (t == typeof(TimeSpan))
                {
                    return reader.Value is DateTimeOffset dto ? dto.TimeOfDay : ((DateTime)reader.Value).TimeOfDay;
                }

                // converter is expected to return a DateTime
                if (reader.Value is DateTimeOffset offset)
                {
                    return offset.DateTime;
                }

                return reader.Value;
            }

            //###
            //if (reader.TokenType != JsonToken.String)
            //{
            //    throw JsonSerializationException.Create(reader, "Unexpected token parsing date. Expected String, got {0}.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
            //}

            var dateText = reader.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(dateText) && nullable)
            {
                return null;
            }

            Debug.Assert(dateText != null);
            if (t == typeof(DateTimeOffset))
            {
                if (!string.IsNullOrWhiteSpace(DateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, DateTimeFormat, Culture, DateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, DateTimeStyles);
                }
            }

            //###
            if (t == typeof(TimeSpan))
            {
                if (!string.IsNullOrWhiteSpace(DateTimeFormat))
                {
                    // Pochta.ru returns times as integer values for some reason,
                    // so leading zeroes are stripped and ParseExact explodes
                    var digits = dateText.Count(char.IsDigit);
                    var expectedDigits = DateTimeFormat.Count(c => "hms".Contains(c));
                    if (digits < expectedDigits)
                    {
                        dateText = new string('0', expectedDigits - digits) + dateText;
                    }

                    return TimeSpan.ParseExact(dateText, DateTimeFormat, Culture, TimeSpanStyles);
                }
                else
                {
                    return TimeSpan.Parse(dateText, Culture);
                }
            }

            if (!string.IsNullOrWhiteSpace(DateTimeFormat))
            {
                return DateTime.ParseExact(dateText, DateTimeFormat, Culture, DateTimeStyles);
            }
            else
            {
                return DateTime.Parse(dateText, Culture, DateTimeStyles);
            }
        }
    }
}
