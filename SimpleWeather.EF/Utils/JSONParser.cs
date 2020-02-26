using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Utf8Json;

#if WINDOWS_UWP
using Windows.Storage;
#endif

namespace SimpleWeather.Utils
{
    public static partial class JSONParser
    {
        // CompositeResolver is singleton helper for use custom resolver.
        // Ofcourse you can also make custom resolver.
        internal static IJsonFormatterResolver Resolver =
            SimpleWeather.EF.Utf8JsonGen.Utf8JsonResolver.Instance;

        static JSONParser()
        {
            JsonSerializer.SetDefaultResolver(Resolver);
        }

        public static T Deserializer<T>(String response)
        {
            return JsonSerializer.Deserialize<T>(response);
        }

        public static T Deserializer<T>(Stream stream)
        {
            var obj = default(T);

            try
            {
                return JsonSerializer.Deserialize<T>(stream);
            }
            catch (Exception ex)
            {
                Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: JSONParser: error deserializing");
            }

            return obj;
        }

        public static Task<T> DeserializerAsync<T>(String response)
        {
            return Task.Run(() => Deserializer<T>(response));
        }

        public static Task<T> DeserializerAsync<T>(Stream stream)
        {
            return Task.Run(() => Deserializer<T>(stream));
        }

#if WINDOWS_UWP
        public static Task<T> DeserializerAsync<T>(StorageFile file)
        {
            return Task.Run(async () =>
            {
                // Wait for file to be free
                while (FileUtils.IsFileLocked(file))
                {
                    await Task.Delay(100).ConfigureAwait(false);
                }

                var obj = default(T);

                try
                {
                    using (var fStream = new FileStream(file.Path, FileMode.Open, FileAccess.Read))
                    {
                        return await JsonSerializer.DeserializeAsync<T>(fStream);
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: JSONParser: error deserializing or with file");
                    obj = default(T);
                }

                return obj;
            });
        }

        public static void Serializer(Object obj, StorageFile file)
        {
            Task.Run(async () =>
            {
                // Wait for file to be free
                while (FileUtils.IsFileLocked(file))
                {
                    await Task.Delay(100).ConfigureAwait(false);
                }

                using (var transaction = await file.OpenTransactedWriteAsync())
                using (var fStream = transaction.Stream.AsStreamForWrite())
                {
                    // Clear file before writing
                    fStream.SetLength(0);

                    await JsonSerializer.SerializeAsync(fStream, obj);
                    await transaction.CommitAsync();
                }
            }).ConfigureAwait(false);
        }
#endif

        public static string Serializer<T>(T obj)
        {
            return JsonSerializer.ToJsonString(obj);
        }

        public static Task<string> SerializerAsync<T>(T obj)
        {
            return Task.Run(() => Serializer(obj));
        }
    }
}