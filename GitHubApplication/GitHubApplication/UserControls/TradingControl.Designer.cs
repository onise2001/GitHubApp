namespace GitHubApplication.UserControls
{
    partial class TradingControl
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
            this.ChoiceRepositories = new System.Windows.Forms.Label();
            this.ChoiceDevelopers = new System.Windows.Forms.Label();
            this.CoiseLanguage = new System.Windows.Forms.Label();
            this.ChoiceDateRAnge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChoiceRepositories
            // 
            this.ChoiceRepositories.AutoSize = true;
            this.ChoiceRepositories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceRepositories.Location = new System.Drawing.Point(22, 23);
            this.ChoiceRepositories.Name = "ChoiceRepositories";
            this.ChoiceRepositories.Size = new System.Drawing.Size(77, 13);
            this.ChoiceRepositories.TabIndex = 1;
            this.ChoiceRepositories.Text = "Repositories";
            // 
            // ChoiceDevelopers
            // 
            this.ChoiceDevelopers.AutoSize = true;
            this.ChoiceDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceDevelopers.Location = new System.Drawing.Point(105, 23);
            this.ChoiceDevelopers.Name = "ChoiceDevelopers";
            this.ChoiceDevelopers.Size = new System.Drawing.Size(71, 13);
            this.ChoiceDevelopers.TabIndex = 2;
            this.ChoiceDevelopers.Text = "Developers";
            // 
            // CoiseLanguage
            // 
            this.CoiseLanguage.AutoSize = true;
            this.CoiseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoiseLanguage.Location = new System.Drawing.Point(439, 23);
            this.CoiseLanguage.Name = "CoiseLanguage";
            this.CoiseLanguage.Size = new System.Drawing.Size(63, 13);
            this.CoiseLanguage.TabIndex = 3;
            this.CoiseLanguage.Text = "Language";
            // 
            // ChoiceDateRAnge
            // 
            this.ChoiceDateRAnge.AutoSize = true;
            this.ChoiceDateRAnge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceDateRAnge.Location = new System.Drawing.Point(575, 23);
            this.ChoiceDateRAnge.Name = "ChoiceDateRAnge";
            this.ChoiceDateRAnge.Size = new System.Drawing.Size(70, 13);
            this.ChoiceDateRAnge.TabIndex = 4;
            this.ChoiceDateRAnge.Text = "Date range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Language";
            // 
            // TradingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiceDateRAnge);
            this.Controls.Add(this.CoiseLanguage);
            this.Controls.Add(this.ChoiceDevelopers);
            this.Controls.Add(this.ChoiceRepositories);
            this.Name = "TradingControl";
            this.Size = new System.Drawing.Size(703, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChoiceRepositories;
        private System.Windows.Forms.Label ChoiceDevelopers;
        private System.Windows.Forms.Label CoiseLanguage;
        private System.Windows.Forms.Label ChoiceDateRAnge;
        private System.Windows.Forms.Label label1;
    }
}
