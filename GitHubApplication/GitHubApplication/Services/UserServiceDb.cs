using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubApplication.Common;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public class UserServiceDb : IUserService
    {

        GitHubAppDbContext dataBase;
        IPasswordHasher hasher = new PasswordHasherSHA512();

        public UserServiceDb(GitHubAppDbContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public User Login(string login, string password)
        {
            var user = dataBase.Users.FirstOrDefault(u => u.UserName.Equals(login, StringComparison.CurrentCultureIgnoreCase) || u.Email == login);

            if (user == null)
                return null;

            if (password == hasher.GetHashedPasswordWithoutSalt(user.Password))
                return user;

            return null;

        }


        public User Register(User user)
        {
            if (dataBase.Users.Any(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)) || dataBase.Users.Any(u => u.Email == user.Email))
                return null;

            dataBase.Users.Add(user);
            dataBase.SaveChanges();
            return user;

        }
    }
}
