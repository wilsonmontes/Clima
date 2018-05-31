﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Clima.Model;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace Clima.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Weather
    {
        [JsonProperty("query")]
        public Query Query { get; set; }
    }

    public partial class Query
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("units")]
        public Units Units { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lastBuildDate")]
        public string LastBuildDate { get; set; }

        [JsonProperty("ttl")]
        public string Ttl { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("atmosphere")]
        public Atmosphere Atmosphere { get; set; }

        [JsonProperty("astronomy")]
        public Astronomy Astronomy { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }
    }

    public partial class Astronomy
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }
    }

    public partial class Atmosphere
    {
        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("rising")]
        public string Rising { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("pubDate")]
        public string PubDate { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("forecast")]
        public Forecast[] Forecast { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("guid")]
        public Guid Guid { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class Forecast
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class Guid
    {
        [JsonProperty("isPermaLink")]
        public string IsPermaLink { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }

    public partial class Units
    {
        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }
    }

    public partial class Wind
    {
        [JsonProperty("chill")]
        public string Chill { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }
    }

    public partial class Weather
    {
        public static Weather FromJson(string json) => JsonConvert.DeserializeObject<Weather>(json, Clima.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Weather self) => JsonConvert.SerializeObject(self, Clima.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

