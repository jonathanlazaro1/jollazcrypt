using System;
using JollazCrypt.Base;
using JollazCrypt.Hashers.HmacSha1;

namespace JollazCrypt.Factories
{
    public static class HasherFactory
    {
        public static BaseHasher Create(HashType hashType)
        {
            switch (hashType)
            {
                case HashType.HmacSha1:
                    return new HmacSha1Hasher();
                default:
                    throw new ArgumentOutOfRangeException("Hash type not found");
            }
        }
    }
}