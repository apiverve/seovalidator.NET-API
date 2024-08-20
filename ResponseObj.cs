using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("passed")]
    public bool passed { get; set; }

    [JsonProperty("entries")]
    public int entries { get; set; }

    [JsonProperty("output")]
    public string[] output { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
