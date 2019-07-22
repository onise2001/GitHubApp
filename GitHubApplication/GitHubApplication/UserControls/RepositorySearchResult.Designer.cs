namespace GitHubApplication.UserControls
{
    partial class RepoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.repoFullNameLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.forksLabel = new System.Windows.Forms.Label();
            this.buildersLabel = new System.Windows.Forms.Label();
            this.repoDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // repoFullNameLabel
            // 
            this.repoFullNameLabel.AutoSize = true;
            this.repoFullNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(92)))), ((int)(((byte)(186)))));
            this.repoFullNameLabel.Location = new System.Drawing.Point(31, 13);
            this.repoFullNameLabel.Name = "repoFullNameLabel";
            this.repoFullNameLabel.Size = new System.Drawing.Size(57, 21);
            this.repoFullNameLabel.TabIndex = 0;
            this.repoFullNameLabel.Text = "label1";
            this.repoFullNameLabel.Click += new System.EventHandler(this.Repo_Click);
            this.repoFullNameLabel.MouseEnter += new System.EventHandler(this.repoFullNameLabel_MouseHover);
            this.repoFullNameLabel.MouseLeave += new System.EventHandler(this.repoFullNameLabel_MouseLeave);
            this.repoFullNameLabel.MouseHover += new System.EventHandler(this.repoFullNameLabel_MouseHover);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(32, 89);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(35, 13);
            this.languageLabel.TabIndex = 1;
            this.languageLabel.Text = "label1";
            // 
            // starsLabel
            // 
            this.starsLabel.AutoSize = true;
            this.starsLabel.Location = new System.Drawing.Point(131, 89);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(35, 13);
            this.starsLabel.TabIndex = 1;
            this.starsLabel.Text = "label1";
            // 
            // forksLabel
            // 
            this.forksLabel.AutoSize = true;
            this.forksLabel.Location = new System.Drawing.Point(246, 89);
            this.forksLabel.Name = "forksLabel";
            this.forksLabel.Size = new System.Drawing.Size(35, 13);
            this.forksLabel.TabIndex = 1;
            this.forksLabel.Text = "label1";
            // 
            // buildersLabel
            // 
            this.buildersLabel.AutoSize = true;
            this.buildersLabel.Location = new System.Drawing.Point(339, 89);
            this.buildersLabel.Name = "buildersLabel";
            this.buildersLabel.Size = new System.Drawing.Size(47, 13);
            this.buildersLabel.TabIndex = 1;
            this.buildersLabel.Text = "Built by :";
            // 
            // repoDescriptionLabel
            // 
            this.repoDescriptionLabel.AutoSize = true;
            this.repoDescriptionLabel.Location = new System.Drawing.Point(32, 50);
            this.repoDescriptionLabel.Name = "repoDescriptionLabel";
            this.repoDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.repoDescriptionLabel.TabIndex = 2;
            this.repoDescriptionLabel.Text = "label5";
            // 
            // RepoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.repoDescriptionLabel);
            this.Controls.Add(this.buildersLabel);
            this.Controls.Add(this.forksLabel);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.repoFullNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RepoControl";
            this.Size = new System.Drawing.Size(479, 111);
            this.Load += new System.EventHandler(this.RepositorySearchResult_Load);
            this.Click += new System.EventHandler(this.Repo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label repoFullNameLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label forksLabel;
        private System.Windows.Forms.Label buildersLabel;
        private System.Windows.Forms.Label repoDescriptionLabel;
    }
}
