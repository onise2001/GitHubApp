using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Services;
using GitHubApplication.Models;

namespace GitHubApplication.UserControls
{
    public partial class UserInfoControl : UserControl
    {
        IUserService userService;
        User User;

        public UserInfoControl(IUserService userservice, User user)
        {
            InitializeComponent();
            User = user;
            userService = userservice;
            FnameTextbox.Text = User.FirstName;
            LNameTextbox.Text = User.LastName;
            EmailTextbox.Text = User.Email;
            UserTextbox.Text = User.UserName;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            PassLabel.ForeColor = Color.Black;
            if(string.IsNullOrEmpty(PassTextbox.Text))
            {
                PassLabel.ForeColor = Color.Red;
                return;
            }
            if (NewPassTextbox.Text == RePassTextbox.Text && !string.IsNullOrEmpty(NewPassTextbox.Text))
            {
                if(userService.PassChange(User, PassTextbox.Text, NewPassTextbox.Text))
                {
                    PassLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                RePasswordLabel.ForeColor = Color.Red;
            }
        }
    }
}
