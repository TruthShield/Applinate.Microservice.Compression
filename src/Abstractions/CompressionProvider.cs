// Copyright (c) TruthShield, LLC. All rights reserved.
namespace Applinate
{
    using Applinate.Compression;

    public static class CompressionProvider
    {
        public static string Compress(this string value) => 
            ServiceProvider.Locate<ICompress>().Compress(value);

        public static string Decompress(this string value) => 
            ServiceProvider.Locate<ICompress>().Decompress(value);
    }
}