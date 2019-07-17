using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GitHubApplication.Common
{
    public class PasswordHasher
    {
        private int saltLength = 24;
        private HashAlgorithm hashAlgorithm = SHA512.Create();
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

        private string CreateSalt()
        {
            byte[] salt = new byte[saltLength];
            provider.GetBytes(salt);
            return salt.ToString();
        }

        private string HashPassword(string password, byte[] salt)
        {
            var deriveBytes = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = deriveBytes.GetBytes(20);
            byte[] hashedPassword = new byte[password.Length + salt.Length];
            Array.Copy(salt, 0, hashedPassword, 0, salt.Length);
            Array.Copy(hash, 0, hashedPassword, salt.Length, hash.Length);
            return hashedPassword.ToString();
        }





    }
}
