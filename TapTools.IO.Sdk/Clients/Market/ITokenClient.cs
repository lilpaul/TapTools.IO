using Refit;
using TapTools.IO.Sdk.Models.Market.Token;
using static TapTools.IO.Sdk.Models.Constants;

namespace TapTools.IO.Sdk.Clients.Market;

public interface ITokenClient
{
    [Get("/token/holders")]
    Task<ApiResponse<TokenHoldersResponse>> TokenHolders(string unit);

    [Get("/token/holders/top")]
    Task<ApiResponse<TopTokenHoldersResponse[]>> TopTokenHolders(string unit, int page = 1, int perPage = 100);

    [Get("/token/indicators")]
    Task<ApiResponse<decimal[]>> TokenPriceIndicators(
        string unit,
        string interval = Interval.FifteenMinutes,
        int items = 100,
        string indicator = Indicator.MovingAverage,
        int? length = null,
        int? smoothingFactor = null,
        int? fastLength = null,
        int? slowLength = null,
        int? signalLength = null,
        int? stdMult = null,
        string quote = "ADA");

    [Get("/token/mcap")]
    Task<ApiResponse<TokenMarketCapResponse>> TokenMarketCap(string unit);

    [Get("/token/ohlcv")]
    Task<ApiResponse<TokenPriceOHLCVResponse[]>> TokenPriceOHLCV(
        string unit,
        string onchainID,
        string interval = Interval.OneHour,
        int numIntervals = 72);

    [Get("/token/pools")]
    Task<ApiResponse<TokenLiquidityPoolsResponse[]>> TokenLiquidityPools(
        string unit,
        string onchainID,
        int adaOnly = PoolAdaOptions.All);

    [Post("/token/prices")]
    Task<ApiResponse<Dictionary<string, decimal>>> TokenPrices([Body] string[] units);

    [Get("/token/quote")]
    Task<ApiResponse<QuotePriceResponse>> QuotePrice(string quote = "USD");

    [Get("/token/quote/available")]
    Task<ApiResponse<string[]>> AvailableQuoteCurrencies();

    [Get("/token/top/liquidity")]
    Task<ApiResponse<TopLiquidityTokensResponse[]>> TopLiquidityTokens(int page = 1, int perPage = 100);

    [Get("/token/top/mcap")]
    Task<ApiResponse<TopMarketCapTokensResponse[]>> TopMarketCapTokens(string type = CirculatingType.Mcap, int page = 1, int perPage = 100);

    [Get("/token/top/volume")]
    Task<ApiResponse<TopVolumeTokensResponse[]>> TopVolumeTokens(string timeframe = Timeframe.OneDay, int page = 1, int perPage = 100);

    [Get("/token/trades")]
    Task<ApiResponse<TokenTradesResponse[]>> TokenTrades(
        string unit,
        long from = 0,
        int minAmount = 0,
        string timeframe = Timeframe.OneDay,
        string sortBy = SortBy.Amount,
        string order = SortOrder.Desc,
        int page = 1,
        int perPage = 100);

    [Get("/token/trading/stats")]
    Task<ApiResponse<TradingStatsResponse>> TradingStats(string unit, string timeframe = Timeframe.OneDay);
}