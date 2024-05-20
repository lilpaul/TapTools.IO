using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Nft;

public class NftSaleHistoryResponse
{
	[JsonInclude]
	public string BuyerStakeAddress { get; set; } = null!;

	[JsonInclude]
	public ulong Price { get; set; }

	[JsonInclude]
	public string SellerStakeAddress { get; set; } = null!;

	[JsonInclude]
	public ulong Time { get; set; }
}