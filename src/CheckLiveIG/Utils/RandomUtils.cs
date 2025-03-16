using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckLiveIG.Utils
{
    public static class RandomUtils
    {
        private static int seed = Environment.TickCount;
        public static ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref RandomUtils.seed)));
        public static string RandomItemInList(this List<string> list)
        {
            return list.Count > 0 ? list[random.Value.Next(list.Count)] : string.Empty;
        }
        public static string RandomStringWithoutUppercase(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[RandomUtils.random.Value.Next(s.Length)]).ToArray());
        }
        public static string RandomStringWithoutNumber(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[RandomUtils.random.Value.Next(s.Length)]).ToArray());
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[RandomUtils.random.Value.Next(s.Length)]).ToArray());
        }
        public static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[RandomUtils.random.Value.Next(s.Length)]).ToArray());
        }
        public static char RandomNumberChar(int length)
        {
            const string chars = "0123456789";
            return chars[RandomUtils.random.Value.Next(chars.Length)];
        }
        public static char GenerateRandomChar(Random random)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return validChars[random.Next(validChars.Length)];
        }
        public static char GenerateRandomCharOnlyNumber(Random random)
        {
            const string validChars = "0123456789";
            return validChars[random.Next(validChars.Length)];
        }
    }
}
