using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TopMarketCapTokensResponse
{
    [JsonInclude]
    public decimal? CircSupply { get; set; }

    [JsonInclude]
    public decimal? Fdv { get; set; }

    [JsonInclude]
    public decimal? Mcap { get; set; }

    [JsonInclude]
    public decimal? Price { get; set; }

    [JsonInclude]
    public string? Ticker { get; set; }

    [JsonInclude]
    public decimal TotalSupply { get; set; }

    [JsonInclude]
    public string Unit { get; set; } = null!;
}