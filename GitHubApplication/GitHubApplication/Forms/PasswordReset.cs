using GitHubApplication.Services;
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
    public partial class PasswordReset : Form
    {

        IUserService userService;

        public PasswordReset(IUserService service)
        {
            InitializeComponent();
            userService = service;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (userService.Reset(MailUserTextbox.Text))
            {
                SentLabel.Visible = true;
            }
            else
            {
                ErrorLabel.Visible = true;
            }
           
        }
    }
}
