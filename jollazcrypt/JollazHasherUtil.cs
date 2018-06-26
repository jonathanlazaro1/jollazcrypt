using System.Collections.Generic;
using JollazCrypt.Factories;

namespace JollazCrypt
{
    public static class JollazHasherUtil
    {
        public static KeyValuePair<string, string> Hash(string text, HashType hashType)
        {
            var hasher = HasherFactory.Create(hashType);
            return hasher.Hash(text);
        }

        public static bool CompareHashed(HashType hashType, string hashedCurrent, string plainNew, string salt)
        {
            var hasher = HasherFactory.Create(hashType);
            return hasher.CompareHashed(hashedCurrent, plainNew, salt);
        }
    }
}