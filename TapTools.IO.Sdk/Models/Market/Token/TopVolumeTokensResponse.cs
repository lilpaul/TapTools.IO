﻿using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TopVolumeTokensResponse
{
    [JsonInclude]
    public decimal? Price { get; set; }

    [JsonInclude]
    public string? Ticker { get; set; }

    [JsonInclude]
    public string Unit { get; set; } = null!;

    [JsonInclude]
    public decimal Volume { get; set; }
}