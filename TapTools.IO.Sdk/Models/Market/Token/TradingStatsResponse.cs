using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TradingStatsResponse
{
    [JsonInclude]
    public decimal BuyVolume { get; set; }

    [JsonInclude]
    public int Buyers { get; set; }

    [JsonInclude]
    public int Buys { get; set; }

    [JsonInclude]
    public decimal SellVolume { get; set; }

    [JsonInclude]
    public int Sellers { get; set; }

    [JsonInclude]
    public int Sells { get; set; }
}