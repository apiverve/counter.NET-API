using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("created")]
    public string created { get; set; }

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("lastAction")]
    public string lastAction { get; set; }

    [JsonProperty("lastRead")]
    public string lastRead { get; set; }

    [JsonProperty("lastUpdated")]
    public string lastUpdated { get; set; }

    [JsonProperty("numberOfDigits")]
    public int numberOfDigits { get; set; }

    [JsonProperty("ordinal")]
    public string ordinal { get; set; }

    [JsonProperty("value")]
    public int value { get; set; }

    [JsonProperty("words")]
    public string words { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
