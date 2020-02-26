using SimpleWeather.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Utf8Json;

namespace SimpleWeather.Utils
{
    using SimpleWeather.EF.Utf8JsonGen;
    using System.Collections;

    public abstract class CustomJsonObject
    {
        public abstract String ToJson();

        /// <summary>
        /// FromJson
        /// </summary>
        /// <param name="reader"></param>
        /// <exception cref="JsonException"></exception>
        public abstract void FromJson(ref JsonReader reader);
    }

    internal class CustomJsonConverter<T> : IJsonFormatter<T> where T : CustomJsonObject
    {
        public T Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
        {
            return JSONParser.CustomDeserializer<T>(ref reader);
        }

        public void Serialize(ref JsonWriter writer, T value, IJsonFormatterResolver formatterResolver)
        {
            JSONParser.CustomSerializer(ref writer, value);
        }
    }

    public static partial class JSONParser
    {
        public static string CustomSerializer<T>(T obj) where T : CustomJsonObject
        {
            var writer = new JsonWriter();
            CustomSerializer(ref writer, obj);
            var str = writer.ToString();
            return str;
        }

        public static T CustomDeserializer<T>(string json) where T : CustomJsonObject
        {
            var reader = new JsonReader(Encoding.UTF8.GetBytes(json));
            return CustomDeserializer<T>(ref reader);
        }

        internal static object CustomDeserializer(ref JsonReader reader, Type type)
        {
            CustomJsonObject obj = null;
            try
            {
                obj = Activator.CreateInstance(type, true) as CustomJsonObject;
                obj.FromJson(ref reader);
            }
            catch (Exception ex)
            {
                Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: CustomJsonConverter: error invoking FromJson method");
            }

            return obj;
        }

        internal static string CustomEnumerableSerializer(ref JsonWriter writer, IEnumerable obj)
        {
            writer.WriteBeginArray();
            var itemCount = 0;
            foreach (var item in obj)
            {
                if (itemCount > 0)
                    writer.WriteValueSeparator();
                CustomSerializer(ref writer, item as CustomJsonObject);
                itemCount++;
            }
            writer.WriteEndArray();
            var str = writer.ToString();
            return str;
        }

        internal static IList CustomEnumerableDeserializer(ref JsonReader reader, Type type)
        {
            var list = new List<object>();
            var count = 0; // managing array-count state in outer(this is count, not index(index is always count - 1)
            reader.ReadIsBeginArrayWithVerify();
            while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
            {
                if (reader.GetCurrentJsonToken() == JsonToken.String)
                    list.Add(CustomDeserializer(ref reader, type));
            }
            if (count == 0) reader.ReadIsValueSeparator();
            return list;
        }

        internal static T CustomDeserializer<T>(ref JsonReader reader) where T : CustomJsonObject
        {
            T obj = null;
            try
            {
                obj = Activator.CreateInstance(typeof(T), true) as T;
                obj.FromJson(ref reader);
            }
            catch (Exception ex)
            {
                Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: CustomJsonConverter: error invoking FromJson method");
            }

            return obj;
        }

        internal static void CustomSerializer<T>(ref JsonWriter writer, T value) where T : CustomJsonObject
        {
            writer.WriteString(value.ToJson());
        }
    }
}
