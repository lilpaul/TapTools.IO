using Microsoft.Extensions.DependencyInjection;
using Refit;
using TapTools.IO.Sdk.Clients.Market;

namespace TapTools.IO.Sdk.Common;

public static class TapToolsExtensions
{
    public static void AddTapTools(this IServiceCollection services, AuthHeaderConfiguration authHeaderConfiguration)
    {
        var uri = new Uri(authHeaderConfiguration.BaseUrl);

        services.AddSingleton(authHeaderConfiguration);
        services.AddTransient<AuthHeaderHandler>();

        services.AddRefitClient<ITokenClient>().ConfigureHttpClient(c => c.BaseAddress = uri).AddHttpMessageHandler<AuthHeaderHandler>();
    }
}