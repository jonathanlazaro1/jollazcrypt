using System;
using System.Collections.Generic;

namespace JollazCrypt.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPlainText = "myPlainText";
            string myOtherPlainText = "myOtherPlainText";

            KeyValuePair<string, string> hashedText = JollazHasherUtil.Hash(myPlainText, HashType.HmacSha1);
            Console.WriteLine($"The hashed text is {hashedText.Key} and the salt is {hashedText.Value}");

            bool thisIsMyPlainText = JollazHasherUtil.CompareHashed(HashType.HmacSha1, hashedText.Key, myPlainText, hashedText.Value); // This is true
            bool thisIsAlsoMyPlainText = JollazHasherUtil.CompareHashed(HashType.HmacSha1, hashedText.Key, myOtherPlainText, hashedText.Value); // This is false

            Console.WriteLine($"The result of comparison of {myPlainText} with the hashed text is {thisIsMyPlainText}.");
            Console.WriteLine($"The result of comparison of {myOtherPlainText} with the hashed text is {thisIsAlsoMyPlainText}.");
        }
    }
}
