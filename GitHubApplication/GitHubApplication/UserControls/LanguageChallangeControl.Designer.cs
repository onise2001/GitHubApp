namespace GitHubApplication.UserControls
{
    partial class LanguageChallangeControl
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
            this.Compare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compare
            // 
            this.Compare.AutoSize = true;
            this.Compare.Location = new System.Drawing.Point(174, 103);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(74, 20);
            this.Compare.TabIndex = 0;
            this.Compare.Text = "Compare";
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // ChallangeResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Compare);
            this.Name = "ChallangeResultControl";
            this.Size = new System.Drawing.Size(1117, 871);
            this.Load += new System.EventHandler(this.ChallangeResultControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Compare;
    }
}
