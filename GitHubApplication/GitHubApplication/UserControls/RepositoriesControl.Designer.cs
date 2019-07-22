namespace GitHubApplication.UserControls
{
    partial class RepositoriesControl
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
            this.RepositoriesName = new System.Windows.Forms.Label();
            this.RepositoriesFullname = new System.Windows.Forms.Label();
            this.Forks = new System.Windows.Forms.Label();
            this.Stars = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RepositoriesName
            // 
            this.RepositoriesName.AutoSize = true;
            this.RepositoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepositoriesName.Location = new System.Drawing.Point(17, 13);
            this.RepositoriesName.Name = "RepositoriesName";
            this.RepositoriesName.Size = new System.Drawing.Size(156, 20);
            this.RepositoriesName.TabIndex = 0;
            this.RepositoriesName.Text = "RepositoriesName";
            // 
            // RepositoriesFullname
            // 
            this.RepositoriesFullname.AutoSize = true;
            this.RepositoriesFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepositoriesFullname.Location = new System.Drawing.Point(18, 56);
            this.RepositoriesFullname.Name = "RepositoriesFullname";
            this.RepositoriesFullname.Size = new System.Drawing.Size(160, 16);
            this.RepositoriesFullname.TabIndex = 1;
            this.RepositoriesFullname.Text = "RepositoriesFullname";
            // 
            // Forks
            // 
            this.Forks.AutoSize = true;
            this.Forks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forks.Location = new System.Drawing.Point(377, 118);
            this.Forks.Name = "Forks";
            this.Forks.Size = new System.Drawing.Size(47, 16);
            this.Forks.TabIndex = 2;
            this.Forks.Text = "Forks";
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(195, 118);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(44, 16);
            this.Stars.TabIndex = 3;
            this.Stars.Text = "Stars";
            this.Stars.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(18, 118);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(77, 16);
            this.Language.TabIndex = 4;
            this.Language.Text = "Language";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.Location = new System.Drawing.Point(18, 84);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(36, 16);
            this.Link.TabIndex = 5;
            this.Link.Text = "Link";
            // 
            // RepositoriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Stars);
            this.Controls.Add(this.Forks);
            this.Controls.Add(this.RepositoriesFullname);
            this.Controls.Add(this.RepositoriesName);
            this.Name = "RepositoriesControl";
            this.Size = new System.Drawing.Size(680, 157);
            this.Load += new System.EventHandler(this.RepositoriesControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RepositoriesName;
        private System.Windows.Forms.Label RepositoriesFullname;
        private System.Windows.Forms.Label Forks;
        private System.Windows.Forms.Label Stars;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label Link;
    }
}
