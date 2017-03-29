﻿namespace PRGReaderLibrary
{
    using System;

    public static class FileVersionUtilities
    {
        public static bool IsDosVersion(byte[] bytes) =>
            bytes.GetString(26, 4).Equals(Constants.Signature, StringComparison.Ordinal);

        public static bool IsCurrentVersion(byte[] bytes, int revision = CurrentVersionConstants.FileRevision) =>
            bytes.ToByte(0) == 0x55 &&
            bytes.ToByte(1) == 0xff &&
            bytes.ToByte(2) == revision; //version

        public static FileVersionEnum GetFileVersion(byte[] bytes)
        {
            if (IsCurrentVersion(bytes, CurrentVersionConstants.FileRevision))
                return FileVersionEnum.Current;

            if (IsDosVersion(bytes))
                return FileVersionEnum.Dos;

            return FileVersionEnum.Unsupported;
        }
    }
}