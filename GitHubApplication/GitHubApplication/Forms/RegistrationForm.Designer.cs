namespace GitHubApplication.Forms
{
    partial class RegistrationForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(230, 84);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(238, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(230, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(238, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(230, 251);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(238, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(230, 309);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(238, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(230, 195);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(238, 20);
            this.emailTextBox.TabIndex = 0;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(230, 427);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(238, 46);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(161, 87);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(160, 144);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(186, 198);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email :";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(158, 254);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(66, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(165, 312);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password :";
            // 
            // repeatePasswordTextBox
            // 
            this.repeatePasswordTextBox.Location = new System.Drawing.Point(230, 369);
            this.repeatePasswordTextBox.Name = "repeatePasswordTextBox";
            this.repeatePasswordTextBox.Size = new System.Drawing.Size(238, 20);
            this.repeatePasswordTextBox.TabIndex = 0;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(127, 372);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(97, 13);
            this.repeatPasswordLabel.TabIndex = 2;
            this.repeatPasswordLabel.Text = "Confirm Password :";
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(227, 353);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(134, 13);
            this.passwordErrorLabel.TabIndex = 3;
            this.passwordErrorLabel.Text = "Password Does Not Match";
            this.passwordErrorLabel.Visible = false;
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userNameErrorLabel.Location = new System.Drawing.Point(227, 235);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(126, 13);
            this.userNameErrorLabel.TabIndex = 3;
            this.userNameErrorLabel.Text = "User Name Already Used";
            this.userNameErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.userNameErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.repeatePasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox repeatePasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label userNameErrorLabel;
    }
}