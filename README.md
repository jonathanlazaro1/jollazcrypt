# JollazCrypt
This package intents to be an useful way to (de)crypt an (un)hash strings and/or integers when using .NET.

## Supported crypters/hashers
These are the crypters/hashers JollazCrypt current supports. This list can increase over time.
- Crypters
  - No crypters are supported at this time :( . We hope we have one soon!
- Hashers
  - HMACSHA1 (10000 salts).

## Installation (NuGet)
You can add the NuGet package using Package Manager on Visual Studio. Just search for *JollazCrypt*.

On Visual Studio Code or using a terminal, you can use the following command:

`dotnet add package JollazCrypt` (you can specify a version using --version *X.XX*)

## Basic usage
First of all, import the namespace where you want to use the tool.

`using JollazCrypt;`
### Hash
Use the *Hash* method, which expects the text to be hashed and the hash type you want. Ex:

`string myPlainText = "myPlainText";`

`KeyValuePair<string, string> hashedText = JollazHasherUtil.Hash(myPlainText, HashType.HmacSha1);`

The return is a KeyValuePair, where key is the hashed text and value is the salt.

### Compare
*CompareHashed* is the method to compare a hashed string with a plain text. It expects the hash type used on the hashed string, the hashed string itself, the plain text and the salt, respectively. Following the previous example, we'd have:

`bool thisIsMyPlainText = JollazHasherUtil.CompareHashed(HashType.HmacSha1, hashedText.Key, myPlainText, hashedText.Value); // This is true`

`bool thisIsAlsoMyPlainText = JollazHasherUtil.CompareHashed(HashType.HmacSha1, hashedText.Key, "myOtherPlainText", hashedText.Value); // This is false`

### Encrypt

Coming soon!

## Enjoy!
There's a project with examples in source. Feel free to ask any questions or suggest improvements!
