using System.Text.Json.Serialization;

namespace TapTools.IO.Sdk.Models.Market.Nft;

public class NftTraitsResponse
{
	public class NftTrait
	{
		[JsonInclude]
		public ulong Category { get; set; }

		[JsonInclude]
		public ulong Name { get; set; }

		[JsonInclude]
		public ulong? Price { get; set; }

		[JsonInclude]
		public decimal? Rarity { get; set; }
	}

	[JsonInclude]
	public ulong Rank { get; set; }

	[JsonInclude]
	public List<NftTrait> Traits { get; set; } = new();
}