﻿namespace GitHubApplication.Forms
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
            this.PassResetButton = new System.Windows.Forms.Button();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.ShowCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(171, 220);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(235, 22);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(171, 278);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signInButton.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(171, 392);
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
            this.loginLabel.Location = new System.Drawing.Point(57, 227);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(108, 14);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "User Name Or Email :";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Location = new System.Drawing.Point(268, 358);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(43, 14);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(106, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 14);
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
            this.PassResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PassResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PassResetButton.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CancelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelLabel.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLabel.Location = new System.Drawing.Point(259, 493);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(41, 16);
            this.CancelLabel.TabIndex = 7;
            this.CancelLabel.Text = "Cancel";
            this.CancelLabel.Click += new System.EventHandler(this.CancelLabel_Click);
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.Depth = 0;
            this.ShowCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ShowCheckBox.Location = new System.Drawing.Point(409, 273);
            this.ShowCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ShowCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Ripple = true;
            this.ShowCheckBox.Size = new System.Drawing.Size(64, 30);
            this.ShowCheckBox.TabIndex = 8;
            this.ShowCheckBox.Text = "Show";
            this.ShowCheckBox.UseVisualStyleBackColor = true;
            this.ShowCheckBox.CheckedChanged += new System.EventHandler(this.ShowCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
        private System.Windows.Forms.Button PassResetButton;
        private System.Windows.Forms.Label CancelLabel;
        private MaterialSkin.Controls.MaterialCheckBox ShowCheckBox;
    }
}