// Copyright (c) TruthShield, LLC. All rights reserved.
namespace Applinate.Compression
{
    public class CompressionTests
    {
        public CompressionTests()
        {
            InitializationProvider.Initialize();
        }

        [Fact]
        public void CompressionTest()
        {
            var val = "testValue";
            var compressed = CompressionProvider.Compress(val);
            var decompressed = CompressionProvider.Decompress(compressed);

            decompressed.Should().Be(val);
            compressed.Should().NotBe(val);
        }
    }
}