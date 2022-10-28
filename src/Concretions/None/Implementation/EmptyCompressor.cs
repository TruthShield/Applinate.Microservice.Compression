namespace Applinate.Compression
{
    internal sealed class EmptyCompressor : ICompress
    {
        public string Compress(string value) => value;

        public string Decompress(string value) => value;
    }
}