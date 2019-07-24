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
    public partial class ShowchallengeResult : UserControl
    {
        GitHubRepository gitHubRepository;
        public ShowchallengeResult(GitHubRepository r)
        {
            InitializeComponent();
            gitHubRepository = r;
        }

        private void ShowchallengeResult_Load(object sender, EventArgs e)
        {

        }
    }
}
