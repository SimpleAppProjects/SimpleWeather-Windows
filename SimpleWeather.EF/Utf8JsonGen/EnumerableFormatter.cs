using SimpleWeather.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utf8Json;

namespace SimpleWeather.EF.Utf8JsonGen
{
    public class EnumerableFormatter<T> : IJsonFormatter<T>
    {
        private Type elementType;

        public EnumerableFormatter()
        {
            if (!(typeof(IEnumerable).IsAssignableFrom(typeof(T)) &&
                typeof(T).GetGenericArguments()?.FirstOrDefault() is Type elementType &&
                typeof(CustomJsonObject).IsAssignableFrom(elementType)))
                throw new System.ArgumentException("type is not valid");

            this.elementType = elementType;
        }

        public T Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
        {
            return (T)JSONParser.CustomEnumerableDeserializer(ref reader, elementType);
        }

        public void Serialize(ref JsonWriter writer, T value, IJsonFormatterResolver formatterResolver)
        {
            JSONParser.CustomEnumerableSerializer(ref writer, value as IEnumerable);
        }
    }
}
