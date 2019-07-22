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
    public partial class RepoControl : UserControl
    {
        Item repo;
        Font defaultRepoNameFont;
        public event EventHandler<Item> SelectedRepo;

        public RepoControl(Item _repo)
        {
            InitializeComponent();
            repo = _repo;
        }

        private void RepositorySearchResult_Load(object sender, EventArgs e)
        {
            repoFullNameLabel.Text = repo.full_name;
            starsLabel.Text = $"{repo.stargazers_count}";
            languageLabel.Text = repo.language;
            forksLabel.Text = $"{repo.forks_count}";
            buildersLabel.Text = repo.owner.login;
            defaultRepoNameFont = repoFullNameLabel.Font;

        }


        private void Repo_Click(object sender, EventArgs e)
        {
            if (sender is RepoControl repoControl)
            {
                SelectedRepo?.Invoke(this, repo);
                Hide();
            }



        }

        private void repoFullNameLabel_MouseHover(object sender, EventArgs e)
        {
            if (sender is RepoControl control)
            {
                control.repoFullNameLabel.Font = new Font(repoFullNameLabel.Font, FontStyle.Underline);
            }
        }

        private void repoFullNameLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is RepoControl control)
            {
                control.repoFullNameLabel.Font = defaultRepoNameFont; 
            }
        }
    }
}
