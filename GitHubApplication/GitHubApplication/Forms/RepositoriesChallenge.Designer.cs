namespace GitHubApplication.Forms
{
    partial class Statistic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showstarsresult = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // showstarsresult
            // 
            this.showstarsresult.Location = new System.Drawing.Point(0, 2);
            this.showstarsresult.Name = "showstarsresult";
            this.showstarsresult.Size = new System.Drawing.Size(797, 447);
            this.showstarsresult.TabIndex = 0;
            this.showstarsresult.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showstarsresult);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel showstarsresult;
    }
}