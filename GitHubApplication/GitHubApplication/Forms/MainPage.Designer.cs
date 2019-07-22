namespace GitHubApplication
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartedRepos_label = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.Statistics_label = new System.Windows.Forms.Label();
            this.StarsCompete_label = new System.Windows.Forms.Label();
            this.Trading_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Settings_label = new System.Windows.Forms.Label();
            this.Bookmarks_label = new System.Windows.Forms.Label();
            this.MyRepos_label = new System.Windows.Forms.Label();
            this.Notification_label = new System.Windows.Forms.Label();
            this.Profile_label = new System.Windows.Forms.Label();
            this.SearchResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control1 = new GitHubApplication.UserControls.Control();
            this.MenuBar.SuspendLayout();
            this.SearchResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Explore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marketplace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issues";
            // 
            // StartedRepos_label
            // 
            this.StartedRepos_label.AutoSize = true;
            this.StartedRepos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartedRepos_label.Location = new System.Drawing.Point(19, 226);
            this.StartedRepos_label.Name = "StartedRepos_label";
            this.StartedRepos_label.Size = new System.Drawing.Size(102, 16);
            this.StartedRepos_label.TabIndex = 2;
            this.StartedRepos_label.Text = "Started repos";
            this.StartedRepos_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.Controls.Add(this.SearchResultPanel);
            this.MenuBar.Controls.Add(this.Statistics_label);
            this.MenuBar.Controls.Add(this.StarsCompete_label);
            this.MenuBar.Controls.Add(this.Trading_label);
            this.MenuBar.Controls.Add(this.richTextBox1);
            this.MenuBar.Controls.Add(this.Search_label);
            this.MenuBar.Controls.Add(this.Settings_label);
            this.MenuBar.Controls.Add(this.Bookmarks_label);
            this.MenuBar.Controls.Add(this.MyRepos_label);
            this.MenuBar.Controls.Add(this.Notification_label);
            this.MenuBar.Controls.Add(this.Profile_label);
            this.MenuBar.Controls.Add(this.label4);
            this.MenuBar.Controls.Add(this.pictureBox1);
            this.MenuBar.Controls.Add(this.label3);
            this.MenuBar.Controls.Add(this.StartedRepos_label);
            this.MenuBar.Controls.Add(this.label2);
            this.MenuBar.Location = new System.Drawing.Point(0, 1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(215, 686);
            this.MenuBar.TabIndex = 1;
            // 
            // Statistics_label
            // 
            this.Statistics_label.AutoSize = true;
            this.Statistics_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics_label.Location = new System.Drawing.Point(24, 382);
            this.Statistics_label.Name = "Statistics_label";
            this.Statistics_label.Size = new System.Drawing.Size(71, 16);
            this.Statistics_label.TabIndex = 14;
            this.Statistics_label.Text = "Statistics";
            // 
            // StarsCompete_label
            // 
            this.StarsCompete_label.AutoSize = true;
            this.StarsCompete_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsCompete_label.Location = new System.Drawing.Point(23, 352);
            this.StarsCompete_label.Name = "StarsCompete_label";
            this.StarsCompete_label.Size = new System.Drawing.Size(106, 16);
            this.StarsCompete_label.TabIndex = 13;
            this.StarsCompete_label.Text = "StarsCompete";
            this.StarsCompete_label.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Trading_label
            // 
            this.Trading_label.AutoSize = true;
            this.Trading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trading_label.Location = new System.Drawing.Point(23, 434);
            this.Trading_label.Name = "Trading_label";
            this.Trading_label.Size = new System.Drawing.Size(62, 16);
            this.Trading_label.TabIndex = 12;
            this.Trading_label.Text = "Trading";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 313);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 33);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(22, 330);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(57, 16);
            this.Search_label.TabIndex = 11;
            this.Search_label.Text = "Serach";
            // 
            // Settings_label
            // 
            this.Settings_label.AutoSize = true;
            this.Settings_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_label.Location = new System.Drawing.Point(23, 464);
            this.Settings_label.Name = "Settings_label";
            this.Settings_label.Size = new System.Drawing.Size(56, 16);
            this.Settings_label.TabIndex = 10;
            this.Settings_label.Text = "Setting";
            // 
            // Bookmarks_label
            // 
            this.Bookmarks_label.AutoSize = true;
            this.Bookmarks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookmarks_label.Location = new System.Drawing.Point(22, 257);
            this.Bookmarks_label.Name = "Bookmarks_label";
            this.Bookmarks_label.Size = new System.Drawing.Size(86, 16);
            this.Bookmarks_label.TabIndex = 9;
            this.Bookmarks_label.Text = "Bookmarks";
            // 
            // MyRepos_label
            // 
            this.MyRepos_label.AutoSize = true;
            this.MyRepos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyRepos_label.Location = new System.Drawing.Point(22, 199);
            this.MyRepos_label.Name = "MyRepos_label";
            this.MyRepos_label.Size = new System.Drawing.Size(72, 16);
            this.MyRepos_label.TabIndex = 8;
            this.MyRepos_label.Text = "My repos";
            // 
            // Notification_label
            // 
            this.Notification_label.AutoSize = true;
            this.Notification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_label.Location = new System.Drawing.Point(22, 132);
            this.Notification_label.Name = "Notification_label";
            this.Notification_label.Size = new System.Drawing.Size(86, 16);
            this.Notification_label.TabIndex = 7;
            this.Notification_label.Text = "Notification";
            // 
            // Profile_label
            // 
            this.Profile_label.AutoSize = true;
            this.Profile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_label.Location = new System.Drawing.Point(22, 101);
            this.Profile_label.Name = "Profile_label";
            this.Profile_label.Size = new System.Drawing.Size(53, 16);
            this.Profile_label.TabIndex = 6;
            this.Profile_label.Text = "Profile";
            // 
            // SearchResultPanel
            // 
            this.SearchResultPanel.Controls.Add(this.control1);
            this.SearchResultPanel.Location = new System.Drawing.Point(218, 3);
            this.SearchResultPanel.Name = "SearchResultPanel";
            this.SearchResultPanel.Size = new System.Drawing.Size(934, 683);
            this.SearchResultPanel.TabIndex = 4;
            this.SearchResultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MenuBar_click);
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(3, 3);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(928, 110);
            this.control1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 688);
            this.Controls.Add(this.MenuBar);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.SearchResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StartedRepos_label;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MyRepos_label;
        private System.Windows.Forms.Label Notification_label;
        private System.Windows.Forms.Label Profile_label;
        private System.Windows.Forms.Label StarsCompete_label;
        private System.Windows.Forms.Label Trading_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label Settings_label;
        private System.Windows.Forms.Label Bookmarks_label;
        private System.Windows.Forms.Label Statistics_label;
        private System.Windows.Forms.FlowLayoutPanel SearchResultPanel;
        private UserControls.Control control1;
    }
}