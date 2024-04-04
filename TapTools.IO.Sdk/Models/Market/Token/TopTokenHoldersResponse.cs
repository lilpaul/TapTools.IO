using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TopTokenHoldersResponse
{
    [JsonInclude]
    public string Address { get; set; } = null!;

    [JsonInclude]
    public decimal Amount { get; set; }
}