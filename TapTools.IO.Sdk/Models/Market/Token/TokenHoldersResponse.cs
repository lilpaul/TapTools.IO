using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Token;

public class TokenHoldersResponse
{
    [JsonInclude]
    public int Holders { get; set; }
}