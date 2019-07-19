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
        private int saltSize = 20;

        RNGCryptoServiceProvider RNGProvider = new RNGCryptoServiceProvider();
        SHA512 hasher = new SHA512Managed();


        

        public string CreateSalt()
        {
            byte[] salt = new byte[saltSize];
            RNGProvider.GetBytes(salt);
            return Encoding.UTF8.GetString(salt);
        }

        public string GetHashedPasswordWithoutSalt(string hashedPassword)
        {
            string withoutSalt = hashedPassword.Substring(saltSize);
            return withoutSalt;
            
        }

        public string GetSalt(string hashedPassword)
        {
            string salt = hashedPassword.Substring(0,saltSize);
            return salt;
        }

     

        //public string Hash(string password)
        //{
        //    byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
        //    byte[] hashedPasswordByte = hasher.ComputeHash(passwordAsBytes);
        //    string hashedPassword = Encoding.UTF8.GetString(hashedPasswordByte);
        //    return hashedPassword;
        //}

        public string HashWithSalt(string password)
        {
            string salt = CreateSalt();

            return salt + Hash(password , salt);
        }


        public string HashWithSalt(string password , string salt)
        {
            return Hash(password, salt);

        }


        public string Hash(string password, string salt)
        {
            byte[] passwordWithSalt = Encoding.UTF8.GetBytes(salt + password);
            byte[] hashedPassword = hasher.ComputeHash(passwordWithSalt);
            string hashedString = Encoding.UTF8.GetString(hashedPassword);
            return hashedString;
        }
    }
}
