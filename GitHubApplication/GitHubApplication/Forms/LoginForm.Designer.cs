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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.PassResetButton = new System.Windows.Forms.Button();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.ForeColor = System.Drawing.Color.White;
            this.loginTextBox.Location = new System.Drawing.Point(171, 220);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(235, 25);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(171, 278);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 25);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(171, 393);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(235, 41);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(38, 224);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(127, 18);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "User Name Or Email :";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(259, 357);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(50, 18);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(86, 281);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password :";
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(209, 159);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(139, 14);
            this.loginErrorLabel.TabIndex = 3;
            this.loginErrorLabel.Text = "Login Or Password Incorrect";
            this.loginErrorLabel.Visible = false;
            // 
            // PassResetButton
            // 
            this.PassResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PassResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassResetButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassResetButton.Location = new System.Drawing.Point(171, 440);
            this.PassResetButton.Name = "PassResetButton";
            this.PassResetButton.Size = new System.Drawing.Size(235, 41);
            this.PassResetButton.TabIndex = 6;
            this.PassResetButton.Text = "Reset Password";
            this.PassResetButton.UseVisualStyleBackColor = false;
            this.PassResetButton.Click += new System.EventHandler(this.PassResetButton_Click);
            // 
            // CancelLabel
            // 
            this.CancelLabel.AutoSize = true;
            this.CancelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLabel.Location = new System.Drawing.Point(259, 493);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(44, 18);
            this.CancelLabel.TabIndex = 7;
            this.CancelLabel.Text = "Cancel";
            this.CancelLabel.Click += new System.EventHandler(this.CancelLabel_Click);
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCheckBox.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCheckBox.Location = new System.Drawing.Point(412, 280);
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Size = new System.Drawing.Size(59, 23);
            this.ShowCheckBox.TabIndex = 8;
            this.ShowCheckBox.Text = "Show";
            this.ShowCheckBox.UseVisualStyleBackColor = false;
            this.ShowCheckBox.CheckedChanged += new System.EventHandler(this.ShowCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(587, 530);
            this.Controls.Add(this.ShowCheckBox);
            this.Controls.Add(this.CancelLabel);
            this.Controls.Add(this.PassResetButton);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
        private System.Windows.Forms.Button PassResetButton;
        private System.Windows.Forms.Label CancelLabel;
        private System.Windows.Forms.CheckBox ShowCheckBox;
    }
}