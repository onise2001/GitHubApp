using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using GitHubApplication.Services;

namespace GitHubApplication.Common
{
    public class PasswordHasherSHA512 : IPasswordHasher
    {
        private int saltLength = 24;
        private HashAlgorithm hashAlgorithm = new SHA512Managed();
        RNGCryptoServiceProvider RNGProvider = new RNGCryptoServiceProvider();



        

        public byte[] CreateSalt()
        {
            byte[] salt = new byte[saltLength];
            RNGProvider.GetBytes(salt);
            return salt;
        }

        public string HashWithSalt(string password)
        {
            byte[] passwordAsBytes = Encoding.ASCII.GetBytes(password);
            byte[] salt = CreateSalt();

            byte[] passwordAndSalt = new byte[passwordAsBytes.Length + salt.Length];
            Array.Copy(salt, 0, passwordAndSalt, 0, salt.Length);
            Array.Copy(passwordAsBytes, 0, passwordAndSalt, salt.Length, passwordAsBytes.Length);

            return hashAlgorithm.ComputeHash(passwordAndSalt).ToString();

        }

        public string Hash(string password)
        {
            return hashAlgorithm.ComputeHash(Encoding.ASCII.GetBytes(password)).ToString();
        }


        public string GetPasswordWithoutSalt(string hashedPassword)
        {
            return hashedPassword.Substring(saltLength);
        }

    }
}
