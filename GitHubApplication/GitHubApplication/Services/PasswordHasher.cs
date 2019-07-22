using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using GitHubApplication.Services;
using System.Text.RegularExpressions;

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
            string withoutSalt = hashedPassword.Substring(saltSize);
            return withoutSalt;

        }

        public string GetSalt(string hashedPassword)
        {
            string salt = hashedPassword.Substring(0,saltSize);
            return salt;
        }




        public string HashWithSalt(string password)
        {
            string salt = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "").Substring(0, saltSize);

            return salt + Hash(password, salt);
        }

        public string Hash(string password, string salt)
        {
            Rfc2898DeriveBytes hashedPassword = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt),1000);

            return hashedPassword.ToString();
        }

        public string HashWithSalt(string password, string salt)
        {
            return Hash(password, salt);

        }


    }
}
