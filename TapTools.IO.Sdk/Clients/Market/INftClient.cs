using Refit;
using TapTools.IO.Sdk.Models.Market.Nft;

namespace TapTools.IO.Sdk.Clients.Market;

public interface INftClient
{
	[Get("/nft/asset/sales")]
	Task<ApiResponse<NftSaleHistoryResponse>> NftSaleHistory(string policy, string name);

	[Get("/nft/asset/stats")]
	Task<ApiResponse<NftStatsResponse>> NftStats(string policy, string name);

	[Get("/nft/asset/traits")]
	Task<ApiResponse<NftTraitsResponse>> NftTraits(string policy, string name, string prices = "1");
}