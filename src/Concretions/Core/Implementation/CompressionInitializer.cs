namespace Applinate.Compression
{
    using Microsoft.Extensions.DependencyInjection;

    internal sealed class CompressionInitializer : IInitialize
    {
        public bool SkipDuringTesting => false;

        public void Initialize(bool testing = false)
        {
            Applinate.ServiceProvider.Register<ICompress>(() => new ConcreteCompressor(), InstanceLifetime.Singleton);
        }
    }
}