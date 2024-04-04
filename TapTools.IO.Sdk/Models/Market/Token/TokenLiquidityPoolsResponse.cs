using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TokenLiquidityPoolsResponse
{
    [JsonInclude]
    public string Exchange { get; set; } = null!;

    [JsonInclude]
    public string LpTokenUnit { get; set; } = null!;

    [JsonInclude]
    public string OnchainID { get; set; } = null!;

    [JsonInclude]
    public string TokenA { get; set; } = null!;

    [JsonInclude]
    public decimal TokenALocked { get; set; }

    [JsonInclude]
    public string TokenATicker { get; set; } = null!;

    [JsonInclude]
    public string TokenB { get; set; } = null!;

    [JsonInclude]
    public decimal TokenBLocked { get; set; }

    [JsonInclude]
    public string TokenBTicker { get; set; } = null!;
}