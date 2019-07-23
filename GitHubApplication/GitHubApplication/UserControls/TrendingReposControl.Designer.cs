namespace GitHubApplication.UserControls
{
    partial class TrendingReposControl
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
            this.CoiseLanguage = new System.Windows.Forms.Label();
            this.ChoiceDateRAnge = new System.Windows.Forms.Label();
            this.developersButton = new System.Windows.Forms.Button();
            this.reposButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CoiseLanguage
            // 
            this.CoiseLanguage.AutoSize = true;
            this.CoiseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoiseLanguage.Location = new System.Drawing.Point(306, 24);
            this.CoiseLanguage.Name = "CoiseLanguage";
            this.CoiseLanguage.Size = new System.Drawing.Size(71, 13);
            this.CoiseLanguage.TabIndex = 3;
            this.CoiseLanguage.Text = "Language :";
            // 
            // ChoiceDateRAnge
            // 
            this.ChoiceDateRAnge.AutoSize = true;
            this.ChoiceDateRAnge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceDateRAnge.Location = new System.Drawing.Point(490, 24);
            this.ChoiceDateRAnge.Name = "ChoiceDateRAnge";
            this.ChoiceDateRAnge.Size = new System.Drawing.Size(78, 13);
            this.ChoiceDateRAnge.TabIndex = 4;
            this.ChoiceDateRAnge.Text = "Date range :";
            // 
            // developersButton
            // 
            this.developersButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.developersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.developersButton.Location = new System.Drawing.Point(92, 19);
            this.developersButton.Name = "developersButton";
            this.developersButton.Size = new System.Drawing.Size(75, 23);
            this.developersButton.TabIndex = 5;
            this.developersButton.Text = "Developers";
            this.developersButton.UseVisualStyleBackColor = false;
            this.developersButton.Click += new System.EventHandler(this.developersButton_Click);
            // 
            // reposButton
            // 
            this.reposButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.reposButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reposButton.Location = new System.Drawing.Point(11, 19);
            this.reposButton.Name = "reposButton";
            this.reposButton.Size = new System.Drawing.Size(75, 23);
            this.reposButton.TabIndex = 5;
            this.reposButton.Text = "Repositories";
            this.reposButton.UseVisualStyleBackColor = false;
            this.reposButton.Click += new System.EventHandler(this.reposButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(383, 21);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(79, 21);
            this.languageComboBox.TabIndex = 6;
            // 
            // dateComboBox
            // 
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(574, 21);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(79, 21);
            this.dateComboBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(302, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultPanel
            // 
            this.searchResultPanel.AutoScroll = true;
            this.searchResultPanel.Location = new System.Drawing.Point(0, 173);
            this.searchResultPanel.Name = "searchResultPanel";
            this.searchResultPanel.Size = new System.Drawing.Size(736, 459);
            this.searchResultPanel.TabIndex = 8;
            // 
            // TrendingReposControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchResultPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.reposButton);
            this.Controls.Add(this.developersButton);
            this.Controls.Add(this.ChoiceDateRAnge);
            this.Controls.Add(this.CoiseLanguage);
            this.Name = "TrendingReposControl";
            this.Size = new System.Drawing.Size(736, 635);
            this.Load += new System.EventHandler(this.TradingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CoiseLanguage;
        private System.Windows.Forms.Label ChoiceDateRAnge;
        private System.Windows.Forms.Button developersButton;
        private System.Windows.Forms.Button reposButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel searchResultPanel;
    }
}
