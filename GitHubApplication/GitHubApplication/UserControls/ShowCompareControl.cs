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
    public partial class ShowCompareControl : UserControl
    {
        public ShowCompareControl(GitHubRepository _repo)
        {
            InitializeComponent();
        }

        private void ShowCompareControl_Load(object sender, EventArgs e)
        {

        }
    }
}
