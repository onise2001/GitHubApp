using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Services
{
    public interface IPasswordHasher
    {
        byte[] CreateSalt();
        string HashWithSalt(string password);
        string HashWithSalt(string password , string salt);
        string Hash(string password , string salt);
        string GetSalt(string hashedPassword);
        string GetHashedPasswordWithoutSalt(string hashedPassword);


    }
}
