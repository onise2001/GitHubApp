﻿namespace GitHubApplication.UserControls
{
    partial class UserInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.RePasswordLabel = new System.Windows.Forms.Label();
            this.FnameTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.LNameTextbox = new System.Windows.Forms.TextBox();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.NewPassTextbox = new System.Windows.Forms.TextBox();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.RePassTextbox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(68, 20);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(73, 16);
            this.FNameLabel.TabIndex = 0;
            this.FNameLabel.Text = "First Name";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(68, 49);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(73, 16);
            this.LNameLabel.TabIndex = 1;
            this.LNameLabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(97, 78);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 16);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-Mail";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(65, 107);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(77, 16);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User Name";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(75, 136);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(68, 16);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Password";
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassLabel.Location = new System.Drawing.Point(44, 165);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(98, 16);
            this.NewPassLabel.TabIndex = 5;
            this.NewPassLabel.Text = "New Password";
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.AutoSize = true;
            this.RePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordLabel.Location = new System.Drawing.Point(25, 194);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(116, 16);
            this.RePasswordLabel.TabIndex = 6;
            this.RePasswordLabel.Text = "Repeat Password";
            // 
            // FnameTextbox
            // 
            this.FnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTextbox.Location = new System.Drawing.Point(150, 14);
            this.FnameTextbox.Name = "FnameTextbox";
            this.FnameTextbox.ReadOnly = true;
            this.FnameTextbox.Size = new System.Drawing.Size(194, 23);
            this.FnameTextbox.TabIndex = 7;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(150, 72);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.ReadOnly = true;
            this.EmailTextbox.Size = new System.Drawing.Size(194, 23);
            this.EmailTextbox.TabIndex = 9;
            // 
            // LNameTextbox
            // 
            this.LNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTextbox.Location = new System.Drawing.Point(150, 43);
            this.LNameTextbox.Name = "LNameTextbox";
            this.LNameTextbox.ReadOnly = true;
            this.LNameTextbox.Size = new System.Drawing.Size(194, 23);
            this.LNameTextbox.TabIndex = 8;
            // 
            // UserTextbox
            // 
            this.UserTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextbox.Location = new System.Drawing.Point(150, 101);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.ReadOnly = true;
            this.UserTextbox.Size = new System.Drawing.Size(194, 23);
            this.UserTextbox.TabIndex = 10;
            // 
            // NewPassTextbox
            // 
            this.NewPassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassTextbox.Location = new System.Drawing.Point(150, 159);
            this.NewPassTextbox.Name = "NewPassTextbox";
            this.NewPassTextbox.Size = new System.Drawing.Size(194, 23);
            this.NewPassTextbox.TabIndex = 12;
            this.NewPassTextbox.UseSystemPasswordChar = true;
            // 
            // PassTextbox
            // 
            this.PassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextbox.Location = new System.Drawing.Point(150, 130);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.Size = new System.Drawing.Size(194, 23);
            this.PassTextbox.TabIndex = 11;
            this.PassTextbox.UseSystemPasswordChar = true;
            // 
            // RePassTextbox
            // 
            this.RePassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RePassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePassTextbox.Location = new System.Drawing.Point(150, 188);
            this.RePassTextbox.Name = "RePassTextbox";
            this.RePassTextbox.Size = new System.Drawing.Size(194, 23);
            this.RePassTextbox.TabIndex = 13;
            this.RePassTextbox.UseSystemPasswordChar = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(150, 217);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(194, 31);
            this.ChangeButton.TabIndex = 14;
            this.ChangeButton.Text = "Change Password";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // UserInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.LNameTextbox);
            this.Controls.Add(this.RePassTextbox);
            this.Controls.Add(this.NewPassTextbox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.FnameTextbox);
            this.Controls.Add(this.RePasswordLabel);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Name = "UserInfoControl";
            this.Size = new System.Drawing.Size(620, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Label RePasswordLabel;
        private System.Windows.Forms.TextBox FnameTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox LNameTextbox;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox NewPassTextbox;
        private System.Windows.Forms.TextBox PassTextbox;
        private System.Windows.Forms.TextBox RePassTextbox;
        private System.Windows.Forms.Button ChangeButton;
    }
}
