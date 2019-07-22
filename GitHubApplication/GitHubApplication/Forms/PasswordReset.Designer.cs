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
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetButton.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(126, 126);
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
            this.MailUserTextbox.Location = new System.Drawing.Point(126, 94);
            this.MailUserTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.MailUserTextbox.Name = "MailUserTextbox";
            this.MailUserTextbox.Size = new System.Drawing.Size(190, 23);
            this.MailUserTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 71);
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
            this.SentLabel.Location = new System.Drawing.Point(126, 16);
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
            this.ErrorLabel.Location = new System.Drawing.Point(172, 43);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(100, 16);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "E-Mail is incorrect";
            this.ErrorLabel.Visible = false;
            // 
            // PasswordReset
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(461, 281);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailUserTextbox);
            this.Controls.Add(this.ResetButton);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordReset";
            this.Text = "PasswordResset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox MailUserTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SentLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}