namespace GitHubApplication.UserControls
{
    partial class ShowchallengeResult
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
            this.Stars = new System.Windows.Forms.Label();
            this.Forks = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(57, 195);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(63, 25);
            this.Stars.TabIndex = 0;
            this.Stars.Text = "Stars";
            // 
            // Forks
            // 
            this.Forks.AutoSize = true;
            this.Forks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forks.Location = new System.Drawing.Point(180, 195);
            this.Forks.Name = "Forks";
            this.Forks.Size = new System.Drawing.Size(66, 25);
            this.Forks.TabIndex = 1;
            this.Forks.Text = "Forks";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(286, 195);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(57, 25);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            // 
            // ShowchallengeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.User);
            this.Controls.Add(this.Forks);
            this.Controls.Add(this.Stars);
            this.Name = "ShowchallengeResult";
            this.Size = new System.Drawing.Size(868, 368);
            this.Load += new System.EventHandler(this.ShowchallengeResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stars;
        private System.Windows.Forms.Label Forks;
        private System.Windows.Forms.Label User;
    }
}
