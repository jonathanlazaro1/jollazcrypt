using System.Collections.Generic;
using JollazCrypt.Factories;

namespace JollazCrypt
{
    public static class JollazCrypterUtil
    {
        public static string Encrypt(string text, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Encrypt(text);
        }

        public static string Encrypt(int number, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Encrypt(number);
        }

        public static string Decrypt(string text, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.Decrypt(text);
        }

        public static int IntegerDecrypt(string text, CryptType cryptType)
        {
            var crypter = CrypterFactory.Create(cryptType);
            return crypter.IntegerDecrypt(text);
        }
    }
}