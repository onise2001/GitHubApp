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
            this.ResetButton = new System.Windows.Forms.Button();
            this.MailUserTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SentLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(108, 102);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(163, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MailUserTextbox
            // 
            this.MailUserTextbox.Location = new System.Drawing.Point(108, 76);
            this.MailUserTextbox.Name = "MailUserTextbox";
            this.MailUserTextbox.Size = new System.Drawing.Size(163, 20);
            this.MailUserTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Mail or Username";
            // 
            // SentLabel
            // 
            this.SentLabel.AutoSize = true;
            this.SentLabel.ForeColor = System.Drawing.Color.Blue;
            this.SentLabel.Location = new System.Drawing.Point(108, 13);
            this.SentLabel.Name = "SentLabel";
            this.SentLabel.Size = new System.Drawing.Size(165, 13);
            this.SentLabel.TabIndex = 3;
            this.SentLabel.Text = "New password was sent to E-mail";
            this.SentLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(148, 35);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(90, 13);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "E-Mail is incorrect";
            this.ErrorLabel.Visible = false;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 228);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailUserTextbox);
            this.Controls.Add(this.ResetButton);
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