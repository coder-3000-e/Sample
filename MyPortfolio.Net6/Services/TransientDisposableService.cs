namespace MyPortfolio.Net6.Services;

public class TransientDisposableService : IDisposable
{
    public void Dispose() => GC.SuppressFinalize(this);
}
