using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastAction")]
        public string LastAction { get; set; }

        [JsonProperty("lastRead")]
        public string LastRead { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("numberOfDigits")]
        public int NumberOfDigits { get; set; }

        [JsonProperty("ordinal")]
        public string Ordinal { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
