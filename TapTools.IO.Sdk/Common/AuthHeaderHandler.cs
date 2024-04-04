namespace TapTools.IO.Sdk.Common;

public record AuthHeaderConfiguration(string ApiAuthKey, string BaseUrl);

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly AuthHeaderConfiguration _authHeaderConfiguration;

    public AuthHeaderHandler(AuthHeaderConfiguration authHeaderConfiguration)
    {
        _authHeaderConfiguration = authHeaderConfiguration;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("x-api-key", _authHeaderConfiguration.ApiAuthKey);
        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}