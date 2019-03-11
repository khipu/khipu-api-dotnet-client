using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Khipu.Client
{
    /// <summary>
    /// Convert an object to a canonical json ( with attributes sorted alphabetically)
    /// </summary>
    public class CanonicalJsonConverter : JsonConverter
    {
        /// <summary>
        /// Get a JsonToken from object and sort properties alphabetically
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);
            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
            }
            else
            {
                JObject o = sortProperties((JObject)t);
                o.WriteTo(writer);
            }
        }
        /// <summary>
        /// Sort properties alphabetically
        /// </summary>

        private JObject sortProperties(JObject o)
        {
            IList<string> propertyNames = o.Properties().OrderBy(p => p.Name).Select(p => p.Name).ToList();
            JObject jobject = new JObject();
            foreach (string key in propertyNames)
            {
                JToken value = o[key];
                if (value.Type != JTokenType.Object)
                {
                    jobject.Add(key, value);
                }
                else
                {
                    jobject.Add(key, sortProperties((JObject)value));
                }
            }
            return jobject;
        }
        /// <summary>
        /// Not implemented
        /// </summary>

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }
        /// <summary>
        /// Is just a writer class read mode is disabled
        /// </summary>

        public override bool CanRead
        {
            get { return false; }
        }
        /// <summary>
        /// Enabled to convert any objectType
        /// </summary>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}