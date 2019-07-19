using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public User Login(string login, string password, bool onLogin)
        {
            var user = dataBase.Users.FirstOrDefault(u => u.UserName.Equals(login, StringComparison.CurrentCultureIgnoreCase) || u.Email == login);

            if (user == null)
                return null;

            if (onLogin)
            {
                if (hasher.HashWithSalt(password, hasher.GetSalt(user.Password)) == hasher.GetHashedPasswordWithoutSalt(user.Password))
                    return user;
            }

            else
            {
                if (password == hasher.GetHashedPasswordWithoutSalt(user.Password))
                    return user;

            }


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

        public bool Reset(string mail)
        {
            var user = dataBase.Users.FirstOrDefault(u => u.Email == mail);
            if (user != null)
            {
                try
                {
                    MailMessage Email = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    Email.From = new MailAddress("github.reset.servive@gmail.com");
                    Email.To.Add(user.Email);
                    Email.Subject = "Password Reset";
                    Email.Body = @"This is your GitApp Password:" + user.Password;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("github.reset.service@gmail.com", "Itstep2018");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(Email);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return true;
            }
            return false;
        }
    }
}
