using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Nft;

public class NftStatsResponse
{
	[JsonInclude]
	public bool IsListed { get; set; }

	[JsonInclude]
	public ulong LastListedPrice { get; set; }

	[JsonInclude]
	public ulong LastListedTime { get; set; }

	[JsonInclude]
	public ulong LastSoldPrice { get; set; }

	[JsonInclude]
	public ulong LastSoldTime { get; set; }

	[JsonInclude]
	public ulong Owners { get; set; }

	[JsonInclude]
	public ulong Sales { get; set; }

	[JsonInclude]
	public ulong TimesListed { get; set; }

	[JsonInclude]
	public ulong Volume { get; set; }
}