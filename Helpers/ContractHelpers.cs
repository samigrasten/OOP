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
        public static void AssertGreaterThanZero(this int value, string error)
        {
            if (value <= 0) throw new ArgumentException(error);
        }
        
        public static void AssertTrue(this bool value, string error)
        {
            if (value != true) throw new ArgumentException(error);
        }
        
        public static void AssertDirectoryExists(this string value, string error)
        {
            if (Directory.Exists(value)) throw new ArgumentException(error);
        }
    }
}
