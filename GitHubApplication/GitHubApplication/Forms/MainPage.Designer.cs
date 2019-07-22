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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.SearchResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Statistics_label = new System.Windows.Forms.Label();
            this.StarsCompete_label = new System.Windows.Forms.Label();
            this.Trading_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Settings_label = new System.Windows.Forms.Label();
            this.Bookmarks_label = new System.Windows.Forms.Label();
            this.Notification_label = new System.Windows.Forms.Label();
            this.Profile_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.MenuBar.Controls.Add(this.Notification_label);
            this.MenuBar.Controls.Add(this.Profile_label);
            this.MenuBar.Controls.Add(this.pictureBox1);
            this.MenuBar.Location = new System.Drawing.Point(0, 1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(215, 686);
            this.MenuBar.TabIndex = 1;
            // 
            // SearchResultPanel
            // 
            this.SearchResultPanel.Location = new System.Drawing.Point(218, 3);
            this.SearchResultPanel.Name = "SearchResultPanel";
            this.SearchResultPanel.Size = new System.Drawing.Size(934, 683);
            this.SearchResultPanel.TabIndex = 4;
            this.SearchResultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
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
            this.StarsCompete_label.Location = new System.Drawing.Point(24, 346);
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
            this.Bookmarks_label.Location = new System.Drawing.Point(22, 175);
            this.Bookmarks_label.Name = "Bookmarks_label";
            this.Bookmarks_label.Size = new System.Drawing.Size(86, 16);
            this.Bookmarks_label.TabIndex = 9;
            this.Bookmarks_label.Text = "Bookmarks";
            this.Bookmarks_label.Click += new System.EventHandler(this.Bookmarks_label_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MenuBar);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}