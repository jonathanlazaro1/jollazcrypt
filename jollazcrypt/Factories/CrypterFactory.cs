using System;
using JollazCrypt.Base;

namespace JollazCrypt.Factories
{
    public static class CrypterFactory
    {
        public static BaseCrypter Create(CryptType cryptType)
        {
            switch (cryptType)
            {
                default:
                    throw new ArgumentOutOfRangeException("Crypt type not found");
            }
        }
    }
}