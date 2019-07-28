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
            this.LanguageChalengPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LanguageChalengPanel
            // 
            this.LanguageChalengPanel.Location = new System.Drawing.Point(2, 0);
            this.LanguageChalengPanel.Name = "LanguageChalengPanel";
            this.LanguageChalengPanel.Size = new System.Drawing.Size(1083, 458);
            this.LanguageChalengPanel.TabIndex = 0;
            this.LanguageChalengPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChallengPanel_Paint);
            // 
            // LanguageChallengform
            // 
            this.ClientSize = new System.Drawing.Size(1087, 462);
            this.Controls.Add(this.LanguageChalengPanel);
            this.Name = "LanguageChallengform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LanguageChallangePanell;
        private System.Windows.Forms.FlowLayoutPanel LanguageChallangeResult;
        private System.Windows.Forms.FlowLayoutPanel LanguageChalengPanel;
    }

}
