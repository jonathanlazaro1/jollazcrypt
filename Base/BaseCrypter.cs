using System;
using System.Collections.Generic;

namespace JollazCrypt.Base
{
    public abstract class BaseCrypter
    {
        public abstract string Encrypt(string plainText);

        public string Encrypt(int plainNumber) => this.Encrypt(plainNumber.ToString());

        public abstract string Decrypt(string encryptedText);

        public int IntegerDecrypt(string encryptedNumber)
        {
            var decryptedNumber = this.Decrypt(encryptedNumber);
            int number;
            if (!int.TryParse(decryptedNumber, out number))
            {
                throw new ArgumentException("Decrypted text is not an integer");
            }
            return number;
        }
    }
}