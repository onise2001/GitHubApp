namespace GitHubApplication.UserControls
{
    partial class ViewRepoControl
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
            this.buildersLabel = new System.Windows.Forms.Label();
            this.forksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // repoFullNameLabel
            // 
            this.repoFullNameLabel.AutoSize = true;
            this.repoFullNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoFullNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.repoFullNameLabel.Location = new System.Drawing.Point(40, 10);
            this.repoFullNameLabel.Name = "repoFullNameLabel";
            this.repoFullNameLabel.Size = new System.Drawing.Size(65, 22);
            this.repoFullNameLabel.TabIndex = 0;
            this.repoFullNameLabel.Text = "label1";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(41, 76);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(35, 13);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "label1";
            // 
            // starsLabel
            // 
            this.starsLabel.AutoSize = true;
            this.starsLabel.Location = new System.Drawing.Point(216, 76);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(35, 13);
            this.starsLabel.TabIndex = 0;
            this.starsLabel.Text = "label1";
            // 
            // buildersLabel
            // 
            this.buildersLabel.AutoSize = true;
            this.buildersLabel.Location = new System.Drawing.Point(539, 76);
            this.buildersLabel.Name = "buildersLabel";
            this.buildersLabel.Size = new System.Drawing.Size(47, 13);
            this.buildersLabel.TabIndex = 0;
            this.buildersLabel.Text = "Built by :";
            // 
            // forksLabel
            // 
            this.forksLabel.AutoSize = true;
            this.forksLabel.Location = new System.Drawing.Point(370, 76);
            this.forksLabel.Name = "forksLabel";
            this.forksLabel.Size = new System.Drawing.Size(35, 13);
            this.forksLabel.TabIndex = 0;
            this.forksLabel.Text = "label1";
            // 
            // ViewRepoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.forksLabel);
            this.Controls.Add(this.buildersLabel);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.repoFullNameLabel);
            this.Name = "ViewRepoControl";
            this.Size = new System.Drawing.Size(735, 98);
            this.Load += new System.EventHandler(this.ViewRepoControl_Load);
            this.Click += new System.EventHandler(this.ViewRepoControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label repoFullNameLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label buildersLabel;
        private System.Windows.Forms.Label forksLabel;
    }
}
