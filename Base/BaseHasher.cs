using System;
using System.Collections.Generic;

namespace JollazCrypt.Base
{
    public abstract class BaseHasher
    {
        public abstract KeyValuePair<string, string> Hash(string plainText, string salt);
        
        public abstract KeyValuePair<string, string> Hash(string plainText);

        public abstract bool CompareHashed(string hashedCurrent, string plainNew, string salt);
    }
}