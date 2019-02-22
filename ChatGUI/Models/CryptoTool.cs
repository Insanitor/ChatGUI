using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ChatGUI.Models
{
    public class CryptoTool
    {
        private static readonly byte[] Key = Convert.FromBase64String("W+jcxfBJm37AAZujiktg4qCdy3k8D+vIrj4exFxFpIY=");

        /// <summary>
        /// Used to Encrypt a string
        /// </summary>
        /// <param name="messageToEncrypt">The Message you wish to encrypt</param>
        /// <returns>Returns the Encrypted Message as a Byte Array</returns>
        public static byte[] Encrypt(string messageToEncrypt)
        {
            try
            {
                byte[] messageAsBytes = Encoding.UTF8.GetBytes(messageToEncrypt);
                byte[] encryptedData;

                //Create an AES Algorytme
                using (var aesAlg = Aes.Create())
                {
                    //Padding decides what to do if the message
                    //is shorter that than the bytes needed
                    aesAlg.Padding = PaddingMode.PKCS7;

                    //Size of the Key used to Encrypt
                    aesAlg.KeySize = 128;

                    //Key used for the Encryption
                    aesAlg.Key = Key;

                    //The Initialization Vector is used to make
                    //the encryption less repetitive, so it's
                    //harder to break with a dictionary attack
                    aesAlg.IV = new byte[128 / 8];

                    //Create an Encrypter
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    //Create a stream to write to
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Create a cryptoStream to encrypt the Stream
                        using (CryptoStream cryptoStream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(cryptoStream))
                            {
                                writer.Write(messageToEncrypt);
                            }
                            encryptedData = stream.ToArray();
                        }
                    }
                }
                return encryptedData;
            }
            catch
            {
                return null;
                throw;
            }
        }

        /// <summary>
        /// Used to decrypt a string
        /// </summary>
        /// <param name="messageToDecrypt">Message to Decrypt as a String</param>
        /// <returns>Returns the Decrypted message as a String</returns>
        public static string Decrypt(string messageToDecrypt)
        {
            try
            {
                string result = null;
                byte[] bytesToDecrypt;
                if (messageToDecrypt != null && messageToDecrypt != "")
                {
                    bytesToDecrypt = Convert.FromBase64String(messageToDecrypt);
                }
                else
                    bytesToDecrypt = new byte[0];

                using (var aesAlg = Aes.Create())
                {
                    aesAlg.Padding = PaddingMode.PKCS7;
                    aesAlg.Key = Key;
                    aesAlg.IV = new byte[128 / 8];

                    ICryptoTransform decrypter = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream stream = new MemoryStream(bytesToDecrypt))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(stream, decrypter, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cryptoStream))
                            {
                                result = reader.ReadToEnd();
                            }
                        }
                    }
                }
                return result;
            }
            catch
            {
                return null;
                throw;
            }
        }

        /// <summary>
        /// Used to decrypt a Byte Array
        /// </summary>
        /// <param name="messageToDecrypt">Message to Decrypt as a String</param>
        /// <returns>Returns the Decrypted message as a String</returns>
        public static string Decrypt(byte[] messageToDecrypt)
        {
            try
            {
                string result = null;

                using (var aesAlg = Aes.Create())
                {
                    aesAlg.Padding = PaddingMode.PKCS7;
                    aesAlg.Key = Key;
                    aesAlg.IV = new byte[128 / 8];

                    ICryptoTransform decrypter = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream stream = new MemoryStream(messageToDecrypt))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(stream, decrypter, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cryptoStream))
                            {
                                result = reader.ReadToEnd();
                            }
                        }
                    }
                }
                return result;
            }
            catch
            {
                return null;
                throw;
            }
        }
    }
}
