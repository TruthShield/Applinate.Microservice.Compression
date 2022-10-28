namespace Applinate.Compression
{
    using System.IO.Compression;
    using System.Text;

    internal sealed class ConcreteCompressor : ICompress
    {
        public string Compress(string value)
        {
            var bytes        = Encoding.UTF8.GetBytes(value);
            var compressed   = Compress(bytes);
            var result       = Convert.ToBase64String(compressed);

            return result;
        }

        public string Decompress(string value)
        {
            var bytes        = Convert.FromBase64String(value);
            var decompressed = Decompress(bytes);
            var result       = Encoding.UTF8.GetString(decompressed);

            return result;
        }

        private static byte[] Compress(byte[] bytes)
        {
            using var ms = new MemoryStream();
            using (var stream = new BrotliStream(ms, CompressionLevel.Optimal))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            return ms.ToArray();
        }

        private static byte[] Decompress(byte[] bytes)
        {
            using var memoryStream = new MemoryStream(bytes);
            using var outputStream = new MemoryStream();

            using (var decompressStream = new BrotliStream(memoryStream, CompressionMode.Decompress))
            {
                decompressStream.CopyTo(outputStream);
            }

            return outputStream.ToArray();
        }
    }
}