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

        GitHubAppDbContext dataBase = new GitHubAppDbContext();


        public User Login(string login , string password)
        {
            return dataBase.Users.FirstOrDefault(u => u.UserName.Equals(login, StringComparison.CurrentCultureIgnoreCase) || u.Email == login && u.Password == password);
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
