using BlazorApp11.Client;

public class AppStateMiddleware
{
    private readonly RequestDelegate _next;

    public AppStateMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var appState = new InitialApplicationState()
        {
            ValueA = "aaa",
            ValueB = null,
            ValueC = null

        };
        var initialAppStateProvider = context.RequestServices.GetRequiredService<InitialApplicationStateProvider>();
        initialAppStateProvider.AppState = appState;

        await _next(context);
    }
}

