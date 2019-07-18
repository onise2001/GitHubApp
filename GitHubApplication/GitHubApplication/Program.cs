using GitHubApplication.Common;
using GitHubApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace GitHubApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ServiceManager.Instance.Container.RegisterType<IUserService, UserServiceDb>();
            ServiceManager.Instance.Container.RegisterType<IPasswordHasher, PasswordHasherSHA512>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = ServiceManager.Instance.Container.Resolve<MainPage>();

            Application.Run(mainForm);
        }
    }
}
