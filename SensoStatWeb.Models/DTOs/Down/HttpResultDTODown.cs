using System;
using Newtonsoft.Json;

namespace SensoStatWeb.Models.DTOs.Down
{
    public class HttpResultDTODown
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("traceId")]
        public string? TraceId { get; set; }
    }
}

