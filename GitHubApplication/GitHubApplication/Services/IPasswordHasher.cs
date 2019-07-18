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
        string Hash(string password);
        string GetHashedPasswordWithoutSalt(string password);



    }
}
