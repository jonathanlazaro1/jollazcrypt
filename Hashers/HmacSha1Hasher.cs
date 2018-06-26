using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using JollazCrypt.Base;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace JollazCrypt.Hashers.HmacSha1
{
    public class HmacSha1Hasher : BaseHasher
    {
        public override KeyValuePair<string, string> Hash(string plainText)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return this.Hash(plainText, Convert.ToBase64String(salt));
        }

        public override bool CompareHashed(string hashedCurrent, string plainNew, string salt)
        {
            KeyValuePair<string, string> hashedNew = this.Hash(plainNew, salt);
            return string.Equals(hashedCurrent, hashedNew.Key);
        }

        public override KeyValuePair<string, string> Hash(string plainText, string salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: plainText,
            salt: Convert.FromBase64String(salt),
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));

            return new KeyValuePair<string, string>(hashed, salt);
        }
    }
}