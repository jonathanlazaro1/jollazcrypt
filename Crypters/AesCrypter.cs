using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using JollazCrypt.Base;

namespace JollazCrypt.Crypters
{
    public class AesCrypter : BaseCrypter
    {
        private const string key = "sAsM4U0ZPv8oYK0IWkvuYDZ7p9HYWHwd";
        public override string Encrypt(string plainText)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("Text is null");
            byte[] encrypted;

            var keyBytes = Encoding.UTF8.GetBytes(key);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyBytes;
                var iv = aesAlg.IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // write iv
                            msEncrypt.Write(iv, 0, iv.Length);
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public override string Decrypt(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText))
                throw new ArgumentNullException("Text is null");
            byte[] encrypted;

            var keyBytes = Encoding.UTF8.GetBytes(key);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyBytes;
                var iv = aesAlg.IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // write iv
                            msEncrypt.Write(iv, 0, iv.Length);
                            //Write all data to the stream.
                            swEncrypt.Write(encryptedText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
    }
}