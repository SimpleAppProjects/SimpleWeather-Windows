using SimpleWeather.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Utf8Json;

namespace SimpleWeather.EF.Utf8JsonGen
{
    public class Utf8JsonResolver : IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new Utf8JsonResolver();

        // configure your resolver and formatters.
        private static readonly IJsonFormatter[] Formatters = new IJsonFormatter[]{
            new Utf8Json.Formatters.DateTimeOffsetFormatter(DateTimeUtils.DATETIMEOFFSET_FORMAT),
            new Utf8Json.Formatters.NullableDateTimeOffsetFormatter(DateTimeUtils.DATETIMEOFFSET_FORMAT)
        };

        private static readonly IJsonFormatterResolver[] Resolvers = new IJsonFormatterResolver[]
        {
                SimpleWeather.EF.Utf8JsonGen.Resolvers.GeneratedResolver.Instance,
#if !EF_PROJECT
                SimpleWeather.Utf8JsonGen.Resolvers.GeneratedResolver.Instance,
#endif
                // set StandardResolver or your use resolver chain
                Utf8Json.Resolvers.AttributeFormatterResolver.Instance,
                Utf8Json.Resolvers.BuiltinResolver.Instance,
                Utf8Json.Resolvers.EnumResolver.UnderlyingValue,
                SimpleWeather.EF.Utf8JsonGen.EnumerableCollectionResolver.Instance
        };

        public IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                foreach (var item in Formatters)
                {
                    foreach (var implInterface in item.GetType().GetTypeInfo().ImplementedInterfaces)
                    {
                        var ti = implInterface.GetTypeInfo();
                        if (ti.IsGenericType && ti.GenericTypeArguments[0] == typeof(T))
                        {
                            Formatter = (IJsonFormatter<T>)item;
                            return;
                        }
                    }
                }

                foreach (var item in Resolvers)
                {
                    var f = item.GetFormatter<T>();
                    if (f != null)
                    {
                        Formatter = f;
                        return;
                    }
                }
            }
        }
    }

    public class AttrFirstUtf8JsonResolver : IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new AttrFirstUtf8JsonResolver();

        // configure your resolver and formatters.
        private static readonly IJsonFormatter[] Formatters = new IJsonFormatter[]{
            new Utf8Json.Formatters.DateTimeOffsetFormatter(DateTimeUtils.DATETIMEOFFSET_FORMAT),
            new Utf8Json.Formatters.NullableDateTimeOffsetFormatter(DateTimeUtils.DATETIMEOFFSET_FORMAT)
        };

        private static readonly IJsonFormatterResolver[] Resolvers = new IJsonFormatterResolver[]
        {
                Utf8Json.Resolvers.AttributeFormatterResolver.Instance,
                SimpleWeather.EF.Utf8JsonGen.Resolvers.GeneratedResolver.Instance,
#if !EF_PROJECT
                SimpleWeather.Utf8JsonGen.Resolvers.GeneratedResolver.Instance,
#endif
                // set StandardResolver or your use resolver chain
                Utf8Json.Resolvers.BuiltinResolver.Instance,
                Utf8Json.Resolvers.EnumResolver.UnderlyingValue,
                SimpleWeather.EF.Utf8JsonGen.EnumerableCollectionResolver.Instance
        };

        public IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                foreach (var item in Formatters)
                {
                    foreach (var implInterface in item.GetType().GetTypeInfo().ImplementedInterfaces)
                    {
                        var ti = implInterface.GetTypeInfo();
                        if (ti.IsGenericType && ti.GenericTypeArguments[0] == typeof(T))
                        {
                            Formatter = (IJsonFormatter<T>)item;
                            return;
                        }
                    }
                }

                foreach (var item in Resolvers)
                {
                    var f = item.GetFormatter<T>();
                    if (f != null)
                    {
                        Formatter = f;
                        return;
                    }
                }
            }
        }
    }

    public class EnumerableCollectionResolver : IJsonFormatterResolver
    {
        public static readonly IJsonFormatterResolver Instance = new EnumerableCollectionResolver();

        EnumerableCollectionResolver()
        {
        }

        public IJsonFormatter<T> GetFormatter<T>()
        {
            if (typeof(T).GetGenericArguments()?.FirstOrDefault() is Type elementType &&
                typeof(CustomJsonObject).IsAssignableFrom(elementType))
                return new EnumerableFormatter<T>();
            return null;
        }
    }
}
