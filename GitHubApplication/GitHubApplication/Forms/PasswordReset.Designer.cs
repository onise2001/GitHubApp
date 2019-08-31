namespace GitHubApplication.Forms
{
    partial class PasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReset));
            this.ResetButton = new System.Windows.Forms.Button();
            this.MailUserTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SentLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Cancellabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(122, 182);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(190, 28);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MailUserTextbox
            // 
            this.MailUserTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MailUserTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailUserTextbox.Location = new System.Drawing.Point(122, 150);
            this.MailUserTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.MailUserTextbox.Name = "MailUserTextbox";
            this.MailUserTextbox.Size = new System.Drawing.Size(190, 23);
            this.MailUserTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Mail or Username";
            // 
            // SentLabel
            // 
            this.SentLabel.AutoSize = true;
            this.SentLabel.ForeColor = System.Drawing.Color.Blue;
            this.SentLabel.Location = new System.Drawing.Point(122, 72);
            this.SentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SentLabel.Name = "SentLabel";
            this.SentLabel.Size = new System.Drawing.Size(171, 16);
            this.SentLabel.TabIndex = 3;
            this.SentLabel.Text = "New password was sent to E-mail";
            this.SentLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(168, 99);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(100, 16);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "E-Mail is incorrect";
            this.ErrorLabel.Visible = false;
            // 
            // Cancellabel2
            // 
            this.Cancellabel2.AutoSize = true;
            this.Cancellabel2.Location = new System.Drawing.Point(190, 241);
            this.Cancellabel2.Name = "Cancellabel2";
            this.Cancellabel2.Size = new System.Drawing.Size(41, 16);
            this.Cancellabel2.TabIndex = 5;
            this.Cancellabel2.Text = "Cancel";
            this.Cancellabel2.Click += new System.EventHandler(this.Cancellabel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GitHubApplication.Properties.Resources.icons8_password_1_48;
            this.pictureBox1.Location = new System.Drawing.Point(75, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordReset
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(461, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancellabel2);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailUserTextbox);
            this.Controls.Add(this.ResetButton);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordReset";
            this.Text = "PasswordResset";
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox MailUserTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SentLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label Cancellabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}