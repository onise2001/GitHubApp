namespace GitHubApplication.Forms
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(171, 204);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(235, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(171, 258);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 20);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(171, 364);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(235, 38);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(57, 207);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(108, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "User Name Or Email :";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.Location = new System.Drawing.Point(268, 332);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(45, 13);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Sign Up";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(106, 261);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password :";
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(209, 148);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(141, 13);
            this.loginErrorLabel.TabIndex = 3;
            this.loginErrorLabel.Text = "Login Or Password Incorrect";
            this.loginErrorLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 492);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label signUpButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}