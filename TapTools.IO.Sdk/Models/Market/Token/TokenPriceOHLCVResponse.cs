using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TokenPriceOHLCVResponse
{
    [JsonInclude]
    public decimal Close { get; set; }

    [JsonInclude]
    public decimal High { get; set; }

    [JsonInclude]
    public decimal Low { get; set; }

    [JsonInclude]
    public decimal Open { get; set; }

    [JsonInclude]
    public int Time { get; set; }

    [JsonInclude]
    public decimal Volume { get; set; }
}