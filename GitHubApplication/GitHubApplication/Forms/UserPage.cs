using GitHubApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
    public partial class UserPage : Form
    {
        User User;
        public UserPage(User user)
        {
            InitializeComponent();
            User = user;
            FNameLabel.Text = user.FirstName;
            LNameLabel.Text = user.LastName;
            FNameLabel.Left = MenuPanel.Size.Width / 2 - FNameLabel.Size.Width/2;
            LNameLabel.Left = MenuPanel.Size.Width / 2 - LNameLabel.Size.Width / 2;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Width = MenuPanel.Width == 210 ? 45 : 210;
        }
    }
}
