namespace GitHubApplication.Forms
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.UserInfoButton = new System.Windows.Forms.Button();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.SettingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.MenuButton);
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Controls.Add(this.pictureBox3);
            this.MenuPanel.Controls.Add(this.UserInfoButton);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.LNameLabel);
            this.MenuPanel.Controls.Add(this.FNameLabel);
            this.MenuPanel.Location = new System.Drawing.Point(0, 64);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(207, 379);
            this.MenuPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Language";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoButton.FlatAppearance.BorderSize = 0;
            this.UserInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInfoButton.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoButton.Location = new System.Drawing.Point(62, 303);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(98, 37);
            this.UserInfoButton.TabIndex = 2;
            this.UserInfoButton.Text = "User Info";
            this.UserInfoButton.UseVisualStyleBackColor = false;
            this.UserInfoButton.Click += new System.EventHandler(this.UserInfoButton_Click);
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(76, 195);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(72, 17);
            this.LNameLabel.TabIndex = 0;
            this.LNameLabel.Text = "LastName";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(76, 160);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(72, 17);
            this.FNameLabel.TabIndex = 0;
            this.FNameLabel.Text = "FirstName";
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingPanel.Location = new System.Drawing.Point(205, 64);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(611, 379);
            this.SettingPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 62);
            this.panel1.TabIndex = 2;
            // 
            // MenuButton
            // 
            this.MenuButton.Image = global::GitHubApplication.Properties.Resources.icons8_menu_24;
            this.MenuButton.Location = new System.Drawing.Point(162, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(45, 42);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 1;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GitHubApplication.Properties.Resources.icons8_male_user_48;
            this.pictureBox2.Location = new System.Drawing.Point(12, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::GitHubApplication.Properties.Resources.icons8_programming_48;
            this.pictureBox3.Location = new System.Drawing.Point(12, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitHubApplication.Properties.Resources.icons8_male_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(62, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(817, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button UserInfoButton;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel SettingPanel;
        private System.Windows.Forms.Panel panel1;
    }
}