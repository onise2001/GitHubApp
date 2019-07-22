namespace GitHubApplication.UserControls
{
    partial class DevelopersControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeveloperFullName = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.projectname = new System.Windows.Forms.Label();
            this.fullnameproject = new System.Windows.Forms.Label();
            this.FollowButtom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DeveloperFullName
            // 
            this.DeveloperFullName.AutoSize = true;
            this.DeveloperFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperFullName.Location = new System.Drawing.Point(141, 20);
            this.DeveloperFullName.Name = "DeveloperFullName";
            this.DeveloperFullName.Size = new System.Drawing.Size(103, 15);
            this.DeveloperFullName.TabIndex = 1;
            this.DeveloperFullName.Text = "name surname";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(141, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 15);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            // 
            // projectname
            // 
            this.projectname.AutoSize = true;
            this.projectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectname.Location = new System.Drawing.Point(383, 20);
            this.projectname.Name = "projectname";
            this.projectname.Size = new System.Drawing.Size(91, 15);
            this.projectname.TabIndex = 3;
            this.projectname.Text = "project name";
            // 
            // fullnameproject
            // 
            this.fullnameproject.AutoSize = true;
            this.fullnameproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameproject.Location = new System.Drawing.Point(383, 66);
            this.fullnameproject.Name = "fullnameproject";
            this.fullnameproject.Size = new System.Drawing.Size(111, 15);
            this.fullnameproject.TabIndex = 4;
            this.fullnameproject.Text = "fullname project";
            // 
            // FollowButtom
            // 
            this.FollowButtom.AutoSize = true;
            this.FollowButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowButtom.Location = new System.Drawing.Point(707, 20);
            this.FollowButtom.Name = "FollowButtom";
            this.FollowButtom.Size = new System.Drawing.Size(49, 15);
            this.FollowButtom.TabIndex = 5;
            this.FollowButtom.Text = "Follow";
            // 
            // DevelopersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FollowButtom);
            this.Controls.Add(this.fullnameproject);
            this.Controls.Add(this.projectname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.DeveloperFullName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DevelopersControl";
            this.Size = new System.Drawing.Size(863, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DeveloperFullName;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label projectname;
        private System.Windows.Forms.Label fullnameproject;
        private System.Windows.Forms.Label FollowButtom;
    }
}
