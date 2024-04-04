using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TapTools.IO.Sdk.Clients.Market;
using TapTools.IO.Sdk.Common;
using static TapTools.IO.Sdk.Models.Constants;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        var apiAuthKey = hostContext.Configuration["TapTools:ApiAuthKey"];
        var baseUrl = hostContext.Configuration["TapTools:BaseUrl"];
        var authConfig = new AuthHeaderConfiguration(apiAuthKey!, baseUrl!);
        services.AddTapTools(authConfig);
        services.AddHostedService<Worker>();
    })
    .Build();
await host.RunAsync();

public class Worker : BackgroundService
{
    private readonly ITokenClient _tokenClient;

    public Worker(
        ITokenClient tokenClient)
    {
        _tokenClient = tokenClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Test Calls
        var tokenTypeId = "782c158a98aed3aa676d9c85117525dcf3acc5506a30a8d87369fbcb4d6f6e6574"; //show me the Monet!
        // - Tokens
        var holders = await _tokenClient.TokenHolders(tokenTypeId);
        var topHolders = await _tokenClient.TopTokenHolders(tokenTypeId);
        var indicators = await _tokenClient.TokenPriceIndicators(tokenTypeId);
        var mcap = await _tokenClient.TokenMarketCap(tokenTypeId);
        var ohlcv = await _tokenClient.TokenPriceOHLCV(
            tokenTypeId,
            "0be55d262b29f564998ff81efe21bdc0022621c12f15af08d0f2ddb1.39b9b709ac8605fc82116a2efc308181ba297c11950f0f350001e28f0e50868b",
            Interval.FifteenMinutes,
            100);
        var pools = await _tokenClient.TokenLiquidityPools(
            tokenTypeId,
            "0be55d262b29f564998ff81efe21bdc0022621c12f15af08d0f2ddb1.39b9b709ac8605fc82116a2efc308181ba297c11950f0f350001e28f0e50868b");
        var prices = await _tokenClient.TokenPrices([tokenTypeId]);
        var price = await _tokenClient.QuotePrice();
        var currencies = await _tokenClient.AvailableQuoteCurrencies();
        var topLiquidity = await _tokenClient.TopLiquidityTokens();
        var topMcap = await _tokenClient.TopMarketCapTokens();
        var topVolume = await _tokenClient.TopVolumeTokens();
        var trades = await _tokenClient.TokenTrades(tokenTypeId);
        var stats = await _tokenClient.TradingStats(tokenTypeId);
    }
}