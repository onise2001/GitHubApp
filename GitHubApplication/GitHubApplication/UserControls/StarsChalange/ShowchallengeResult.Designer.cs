namespace GitHubApplication.UserControls.StarsChalange
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
            this.FirstStar = new System.Windows.Forms.Label();
            this.SecondStar = new System.Windows.Forms.Label();
            this.SecondLanguage = new System.Windows.Forms.Label();
            this.FirstLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstStar
            // 
            this.FirstStar.AutoSize = true;
            this.FirstStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstStar.Location = new System.Drawing.Point(18, 93);
            this.FirstStar.Name = "FirstStar";
            this.FirstStar.Size = new System.Drawing.Size(16, 16);
            this.FirstStar.TabIndex = 0;
            this.FirstStar.Text = "0";
            // 
            // SecondStar
            // 
            this.SecondStar.AutoSize = true;
            this.SecondStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondStar.Location = new System.Drawing.Point(715, 93);
            this.SecondStar.Name = "SecondStar";
            this.SecondStar.Size = new System.Drawing.Size(16, 16);
            this.SecondStar.TabIndex = 1;
            this.SecondStar.Text = "0";
            // 
            // SecondLanguage
            // 
            this.SecondLanguage.AutoSize = true;
            this.SecondLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLanguage.Location = new System.Drawing.Point(715, 31);
            this.SecondLanguage.Name = "SecondLanguage";
            this.SecondLanguage.Size = new System.Drawing.Size(16, 16);
            this.SecondLanguage.TabIndex = 2;
            this.SecondLanguage.Text = "0";
            // 
            // FirstLanguage
            // 
            this.FirstLanguage.AutoSize = true;
            this.FirstLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLanguage.Location = new System.Drawing.Point(18, 31);
            this.FirstLanguage.Name = "FirstLanguage";
            this.FirstLanguage.Size = new System.Drawing.Size(16, 16);
            this.FirstLanguage.TabIndex = 3;
            this.FirstLanguage.Text = "0";
            // 
            // ShowchallengeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FirstLanguage);
            this.Controls.Add(this.SecondLanguage);
            this.Controls.Add(this.SecondStar);
            this.Controls.Add(this.FirstStar);
            this.Name = "ShowchallengeResult";
            this.Size = new System.Drawing.Size(782, 132);
            this.Load += new System.EventHandler(this.ShowchallengeResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstStar;
        private System.Windows.Forms.Label SecondStar;
        private System.Windows.Forms.Label SecondLanguage;
        private System.Windows.Forms.Label FirstLanguage;
    }
}
