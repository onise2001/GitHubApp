using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Common;
using GitHubApplication.Models;
using Microsoft.EntityFrameworkCore;

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
                var guid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "").Substring(0, 6);
                MailSend(user, guid);

                user.Password = hasher.HashWithSalt(guid);
                dataBase.Users.Update(user);
                //dataBase.Users.Attach(user);
                //dataBase.Entry(user).State = EntityState.Modified;
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }

        private static void MailSend(User user, string text)
        {
            MailMessage Email = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            Email.From = new MailAddress("github.reset.servive@gmail.com");
            Email.To.Add(user.Email);
            Email.Subject = "Password Reset";
            Email.Body = @"This is your GitApp Password: " + text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("github.reset.service@gmail.com", "Itstep2018");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(Email);
        }

        public bool PassChange(User user, string current, string newpass)
        {
            var Current = hasher.GetHashedPasswordWithoutSalt(hasher.HashWithSalt(current));
            var CurrentUserPass = hasher.GetHashedPasswordWithoutSalt(user.Password);
            if (Current== CurrentUserPass)
            {
                user.Password = hasher.HashWithSalt(newpass);
                dataBase.Users.Update(user);
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
