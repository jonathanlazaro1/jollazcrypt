using System;
using JollazCrypt.Base;
using JollazCrypt.Crypters;

namespace JollazCrypt.Factories
{
    public static class CrypterFactory
    {
        public static BaseCrypter Create(CryptType cryptType)
        {
            switch (cryptType)
            {
                case CryptType.Aes:
                    return new AesCrypter();
                default:
                    throw new ArgumentOutOfRangeException("Crypt type not found");
            }
        }
    }
}