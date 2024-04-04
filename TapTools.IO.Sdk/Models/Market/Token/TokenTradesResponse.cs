using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TokenTradesResponse
{
    [JsonInclude]
    public string Action { get; set; } = null!;

    [JsonInclude]
    public string Address { get; set; } = null!;

    [JsonInclude]
    public string Exchange { get; set; } = null!;

    [JsonInclude]
    public string Hash { get; set; } = null!;

    [JsonInclude]
    public decimal Price { get; set; }

    [JsonInclude]
    public long Time { get; set; }

    [JsonInclude]
    public string TokenA { get; set; } = null!;

    [JsonInclude]
    public decimal TokenAAmount { get; set; }

    [JsonInclude]
    public string TokenAName { get; set; } = null!;

    [JsonInclude]
    public string TokenB { get; set; } = null!;

    [JsonInclude]
    public decimal TokenBAmount { get; set; }

    [JsonInclude]
    public string TokenBName { get; set; } = null!;
}