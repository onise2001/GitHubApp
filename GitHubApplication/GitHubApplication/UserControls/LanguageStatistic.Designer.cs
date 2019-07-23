namespace GitHubApplication.UserControls
{
    partial class LanguageStatistic
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
            this.Language = new System.Windows.Forms.Label();
            this.Stars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(213, 19);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(77, 16);
            this.Language.TabIndex = 0;
            this.Language.Text = "Language";
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(348, 19);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(39, 16);
            this.Stars.TabIndex = 1;
            this.Stars.Text = "Stars";
            // 
            // LanguageStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Stars);
            this.Controls.Add(this.Language);
            this.Name = "LanguageStatistic";
            this.Size = new System.Drawing.Size(623, 150);
            this.Load += new System.EventHandler(this.LanguageStatistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label Stars;
    }
}
