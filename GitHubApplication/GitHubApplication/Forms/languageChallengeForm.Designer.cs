namespace GitHubApplication.Forms
{
    partial class LanguageChallengform
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
            this.ChallengPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ChallengPanel
            // 
            this.ChallengPanel.Location = new System.Drawing.Point(2, 69);
            this.ChallengPanel.Name = "ChallengPanel";
            this.ChallengPanel.Size = new System.Drawing.Size(1478, 681);
            this.ChallengPanel.TabIndex = 0;
            this.ChallengPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChallengPanel_Paint);
            // 
            // LanguageChallengform
            // 
            this.ClientSize = new System.Drawing.Size(1488, 762);
            this.Controls.Add(this.ChallengPanel);
            this.Name = "LanguageChallengform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LanguageChallangePanell;
        private System.Windows.Forms.FlowLayoutPanel LanguageChallangeResult;
        private System.Windows.Forms.FlowLayoutPanel ChallengPanel;
    }

}
