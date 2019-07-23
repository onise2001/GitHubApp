using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using GitHubApplication.Models;
using GitHubApplication.Services;
using GitHubApplication.UserControls;

namespace GitHubApplication.Forms
{
    public partial class UserPage : MaterialForm
    {
        User User;
        IUserService userService;

        public UserPage(IUserService userservice)
        {
            InitializeComponent();
            userService = userservice;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Width = MenuPanel.Width == 210 ? 55 : 210;
            MenuButton.Left= MenuPanel.Width == 55 ? 3 : 162;
        }

        internal void GetUser(object sender, User e)
        {
            User = e;
            FNameLabel.Text = User.FirstName;
            LNameLabel.Text = User.LastName;
            FNameLabel.Left = MenuPanel.Width / 2 - FNameLabel.Width / 2;
            LNameLabel.Left = MenuPanel.Width / 2 - LNameLabel.Width / 2;
        }

        private void UserInfoButton_Click(object sender, EventArgs e)
        {
            SettingPanel.Controls.Clear();
            var userinfo = new UserInfoControl(userService, User);
            SettingPanel.Controls.Add(userinfo);

        }
    }
}
