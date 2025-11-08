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
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("passed")]
        public bool Passed { get; set; }

        [JsonProperty("entries")]
        public int Entries { get; set; }

        [JsonProperty("output")]
        public string[] Output { get; set; }

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
