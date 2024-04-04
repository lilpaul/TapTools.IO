using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class QuotePriceResponse
{
    [JsonInclude]
    public decimal Price { get; set; }
}