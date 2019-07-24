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

        private async void ResetButton_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer
            {
                Interval = 10000
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            ResetButton.Enabled = false;

            var s = await Task.Run(() => userService.Reset(MailUserTextbox.Text));
            if (s)
            {
                SentLabel.Visible = true;
            }
            else
            {
                ErrorLabel.Visible = true;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ResetButton.Enabled = true;
            if (sender is Timer timer)
            {
                timer.Stop();
            }
            
        }

        private void Cancellabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
