using System.Collections.Generic;
using JollazCrypt.Factories;

namespace JollazCrypt
{
    public static class JollazCrypterUtil
    {
        public static string Encrypt(string text, string key, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Encrypt(text, key);
        }

        public static string Encrypt(int number, string key, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Encrypt(number, key);
        }

        public static string Decrypt(string text, string key, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Decrypt(text, key);
        }

        public static int IntegerDecrypt(string text, string key, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.IntegerDecrypt(text, key);
        }
    }
}