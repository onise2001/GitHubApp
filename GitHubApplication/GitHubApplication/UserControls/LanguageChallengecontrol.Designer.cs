namespace GitHubApplication.UserControls
{
    partial class LanguagesChallengecontrol
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
            this.Ruby = new System.Windows.Forms.Label();
            this.java = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Ruby
            // 
            this.Ruby.AutoSize = true;
            this.Ruby.Location = new System.Drawing.Point(517, 65);
            this.Ruby.Name = "Ruby";
            this.Ruby.Size = new System.Drawing.Size(32, 13);
            this.Ruby.TabIndex = 2;
            this.Ruby.Text = "Ruby";
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(99, 65);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(27, 13);
            this.java.TabIndex = 3;
            this.java.Text = "java";
            // 
            // compare
            // 
            this.compare.AutoSize = true;
            this.compare.Location = new System.Drawing.Point(313, 173);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(48, 13);
            this.compare.TabIndex = 4;
            this.compare.Text = "compare";
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 206);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 301);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // LanguagesChallengecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.java);
            this.Controls.Add(this.Ruby);
            this.Name = "LanguagesChallengecontrol";
            this.Size = new System.Drawing.Size(743, 510);
            this.Load += new System.EventHandler(this.LanguagesChallengecontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ruby;
        private System.Windows.Forms.Label java;
        private System.Windows.Forms.Label compare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
