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
    public partial class ViewRepoControl : UserControl
    {
        GitHubRepository repo;

        public event EventHandler<GitHubRepository> SelectedRepo;

        public ViewRepoControl(GitHubRepository _repo)
        {
            InitializeComponent();
            repo = _repo;
        }

        private void ViewRepoControl_Load(object sender, EventArgs e)
        {
            repoFullNameLabel.Text = repo.full_name;
            languageLabel.Text = repo.language;
            starsLabel.Text = repo.stargazers_count.ToString();
            forksLabel.Text = repo.forks_count.ToString();

        }

        private void ViewRepoControl_Click(object sender, EventArgs e)
        {
            SelectedRepo?.Invoke(this, repo);
            Hide();
        }
    }
}
