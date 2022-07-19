using Newtonsoft.Json;
using System;

namespace Server.JsonConverters
{
    public class BoolConverter : JsonConverter<bool>
    {
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var tokenType = reader.TokenType;
            if (tokenType == JsonToken.Null)
            {
                return false;
            }

            if (tokenType == JsonToken.Boolean)
            {
                return (bool)(reader?.Value ?? false);
            }

            if (tokenType != JsonToken.String)
            {
                throw new Exception(string.Format($"Invalid Token {tokenType}"));
            }

            var stringValue = (string)(reader?.Value ?? string.Empty);
            return string.Equals(bool.TrueString, stringValue, StringComparison.OrdinalIgnoreCase);
        }
    }
}
