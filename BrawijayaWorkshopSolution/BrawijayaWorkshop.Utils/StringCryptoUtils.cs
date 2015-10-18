using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BrawijayaWorkshop.Utils
{
    public static class StringCryptoUtils
    {
        private static readonly byte[] _key = new byte[] { 9, 8, 3, 4, 9, 6, 7, 3 };
        private static readonly byte[] _iv = new byte[] { 2, 5, 7, 8, 5, 6, 3, 8 };

        public static string ComputeHash(this string sender, string hashAlgorithm, string saltHashing)
        {
            byte[] saltBytes = new byte[saltHashing.Length];

            if (saltBytes == null)
            {
                int minSaltSize = 4;
                int maxSaltSize = 8;

                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);

                saltBytes = new byte[saltSize];

                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                rng.GetNonZeroBytes(saltBytes);
            }

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(sender);

            byte[] plainTextWithSaltBytes =
                    new byte[plainTextBytes.Length + saltBytes.Length];

            for (int i = 0; i < plainTextBytes.Length; i++)
                plainTextWithSaltBytes[i] = plainTextBytes[i];

            for (int i = 0; i < saltBytes.Length; i++)
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];

            HashAlgorithm hash;

            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hash = new SHA1Managed();
                    break;

                case "SHA256":
                    hash = new SHA256Managed();
                    break;

                case "SHA384":
                    hash = new SHA384Managed();
                    break;

                case "SHA512":
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            hash = new MD5CryptoServiceProvider();

            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            byte[] hashWithSaltBytes = new byte[hashBytes.Length +
                                                saltBytes.Length];

            for (int i = 0; i < hashBytes.Length; i++)
                hashWithSaltBytes[i] = hashBytes[i];

            for (int i = 0; i < saltBytes.Length; i++)
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];

            string hashValue = Convert.ToBase64String(hashWithSaltBytes);
            return hashValue;
        }

        public static string Encrypt(this string sender)
        {
            try
            {
                // convert data to byte array
                byte[] sourceDataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(sender);

                // get target memory stream
                MemoryStream tempStream = new MemoryStream();

                // get encryptor and encryption stream
                DESCryptoServiceProvider encryptor = new DESCryptoServiceProvider();
                CryptoStream encryptionStream = new CryptoStream(tempStream,
                      encryptor.CreateEncryptor(_key, _iv), CryptoStreamMode.Write);

                // encrypt data
                encryptionStream.Write(sourceDataBytes, 0, sourceDataBytes.Length);
                encryptionStream.FlushFinalBlock();

                // put data into byte array
                byte[] encryptedDataBytes = tempStream.GetBuffer();

                // convert encrypted data into string
                return Convert.ToBase64String(encryptedDataBytes, 0, (int)tempStream.Length);
            }
            catch (Exception ex)
            {
                throw new StringCryptoUtilsException("Unable to encrypt data.", ex);
            }
        }

        public static string Decrypt(this string sender)
        {
            try
            {
                // convert data to byte array
                byte[] encryptedDataBytes = Convert.FromBase64String(sender);

                // get source memory stream and fill it 
                MemoryStream tempStream = new MemoryStream(encryptedDataBytes, 0, encryptedDataBytes.Length);

                // get decryptor and decryption stream 
                DESCryptoServiceProvider decryptor = new DESCryptoServiceProvider();
                CryptoStream decryptionStream = new CryptoStream(tempStream,
                      decryptor.CreateDecryptor(_key, _iv), CryptoStreamMode.Read);

                // decrypt data
                StreamReader allDataReader = new StreamReader(decryptionStream);
                return allDataReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new StringCryptoUtilsException("Unable to decrypt data.", ex);
            }
        }
    }

    public class StringCryptoUtilsException : Exception
    {
        public StringCryptoUtilsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}