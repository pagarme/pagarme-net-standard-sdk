// <copyright file="MapDateTimeConverter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Utilities
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Extends from JsonConverter, allows the use of a custom converter.
    /// </summary>
    public class MapDateTimeConverter : JsonConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        public MapDateTimeConverter()
        {
            this.Converter = new IsoDateTimeConverter();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        public MapDateTimeConverter(Type converter)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        /// <param name="format">format.</param>
        public MapDateTimeConverter(Type converter, string format)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter, format);
        }

        /// <summary>
        /// Gets or sets the JsonConverter.
        /// </summary>
        public JsonConverter Converter { get; set; }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(this.Converter);
            serializer.Serialize(writer, value);
        }

        /// <inheritdoc/>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(this.Converter);
            return serializer.Deserialize(reader, objectType);
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string,DateTime>) || objectType == typeof(Dictionary<string,DateTimeOffset>) || objectType == typeof(DateTime) || objectType == typeof(DateTimeOffset);
        }
    }
}