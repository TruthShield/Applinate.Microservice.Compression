namespace Applinate.Compression
{
    using Microsoft.Extensions.DependencyInjection;

    internal sealed class CompressionInitializer : IInitialize
    {
        public bool SkipDuringTesting => false;

        public void Initialize(IServiceCollection services, bool testing = false)
        {
            Applinate.ServiceProvider.RegisterSingleton<ICompress, EmptyCompressor>();
        }
    }
}