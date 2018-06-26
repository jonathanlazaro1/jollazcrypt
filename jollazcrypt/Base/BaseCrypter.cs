using System;
using System.Collections.Generic;

namespace JollazCrypt.Base
{
    public abstract class BaseCrypter
    {
        public abstract string Encrypt(string plainText, string key);

        public string Encrypt(int plainNumber, string key) => this.Encrypt(plainNumber.ToString(), key);

        public abstract string Decrypt(string encryptedText, string key);

        public int IntegerDecrypt(string encryptedNumber, string key)
        {
            var decryptedNumber = this.Decrypt(encryptedNumber, key);
            int number;
            if (!int.TryParse(decryptedNumber, out number))
            {
                throw new ArgumentException("Decrypted text is not an integer");
            }
            return number;
        }
    }
}