using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Models;

namespace GitHubApplication.UserControls
{
    public partial class DevelopersControl : UserControl
    {

        GitHubUser user;



        public DevelopersControl(GitHubUser _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void DevelopersControl_Load(object sender, EventArgs e)
        {
          //  developerFullNameLabel.Text = user.login;


        }
    }
}
