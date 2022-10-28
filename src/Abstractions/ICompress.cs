// Copyright (c) TruthShield, LLC. All rights reserved.
namespace Applinate.Compression
{
    public interface ICompress
    {
        String Compress(String value);

        String Decompress(String value);
    }
}