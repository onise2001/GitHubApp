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


        

        public byte[] CreateSalt()
        {
            byte[] salt = new byte[saltSize];
            RNGProvider.GetBytes(salt);
            return salt;
        }

        public string GetHashedPasswordWithoutSalt(string hashedPassword)
        {
            int hashedSaltLenght = hasher.ComputeHash(CreateSalt()).Length;

            byte[] passwordAsBytes = Encoding.ASCII.GetBytes(hashedPassword);
            byte[] passwordWithoutSalt = new byte[passwordAsBytes.Length - hashedSaltLenght];
            Array.Copy(passwordAsBytes, hashedSaltLenght, passwordWithoutSalt, 0, passwordAsBytes.Length - hashedSaltLenght);

            string password = Encoding.ASCII.GetString(passwordWithoutSalt);
            return password;


        }

     

        public string Hash(string password)
        {
            byte[] passwordAsBytes = Encoding.ASCII.GetBytes(password);
            string hashedPassword = Encoding.ASCII.GetString(hasher.ComputeHash(passwordAsBytes));
            return hashedPassword;
        }

        public string HashWithSalt(string password)
        {
            byte[] salt = CreateSalt();
            byte[] passwordAsBytes = Encoding.ASCII.GetBytes(password);

            byte[] hashedSalt = hasher.ComputeHash(salt);
            byte[] hashedPassword = hasher.ComputeHash(passwordAsBytes);
            byte[] passwordWithSalt = new byte[hashedSalt.Length + hashedPassword.Length];

            
            Array.Copy(hashedSalt, 0, passwordWithSalt, 0, hashedSalt.Length);
            Array.Copy(hashedPassword, 0, passwordWithSalt, hashedSalt.Length, hashedPassword.Length);

            

            return Encoding.ASCII.GetString(passwordWithSalt);

        }

        


    }
}
