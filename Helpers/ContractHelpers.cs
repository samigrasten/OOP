using System;
using System.IO;

namespace OOP.Helpers
{
    public static class ContractHelpers
    {
        public static void AssertNotNullOrEmpty(this string value, string error)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException(error);
        }
        public static void AssertDirectoryExists(this string value, string error)
        {
            if (Directory.Exists(value)) throw new ArgumentException(error);
        }
    }
}
