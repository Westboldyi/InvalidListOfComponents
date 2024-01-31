namespace BlazorApp11.Client
{
    public class InitialApplicationStateProvider
    {
        public InitialApplicationState? AppState { get; set; }
    }

    public class InitialApplicationState
    {
        public required string? ValueA { get; set; }
        public required string? ValueB { get; set; }
        public required string? ValueC { get; set; }
    }
}
