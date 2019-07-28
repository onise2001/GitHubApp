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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowchallengeResult));
            this.Stars = new System.Windows.Forms.Label();
            this.Forks = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Language = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(37, 87);
            this.Stars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(46, 17);
            this.Stars.TabIndex = 0;
            this.Stars.Text = "Stars";
            // 
            // Forks
            // 
            this.Forks.AutoSize = true;
            this.Forks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forks.Location = new System.Drawing.Point(142, 87);
            this.Forks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Forks.Name = "Forks";
            this.Forks.Size = new System.Drawing.Size(48, 17);
            this.Forks.TabIndex = 1;
            this.Forks.Text = "Forks";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(276, 87);
            this.User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(42, 17);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(113, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(2, 15);
            this.Language.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(42, 17);
            this.Language.TabIndex = 5;
            this.Language.Text = "Java";
            this.Language.Click += new System.EventHandler(this.Language_Click);
            // 
            // ShowchallengeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Language);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Forks);
            this.Controls.Add(this.Stars);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowchallengeResult";
            this.Size = new System.Drawing.Size(1093, 154);
            this.Load += new System.EventHandler(this.ShowchallengeResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stars;
        private System.Windows.Forms.Label Forks;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Language;
    }
}
