namespace GitHubApplication.UserControls
{
    partial class LanguageChallangeControl
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
            this.Compare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChalangeResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Java = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.Ruby = new System.Windows.Forms.Label();
            this.C_Sharp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compare
            // 
            this.Compare.AutoSize = true;
            this.Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compare.Location = new System.Drawing.Point(296, 201);
            this.Compare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(71, 16);
            this.Compare.TabIndex = 0;
            this.Compare.Text = "Compare";
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "c#";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "java";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "VS";
            // 
            // ChalangeResultPanel
            // 
            this.ChalangeResultPanel.Location = new System.Drawing.Point(3, 251);
            this.ChalangeResultPanel.Name = "ChalangeResultPanel";
            this.ChalangeResultPanel.Size = new System.Drawing.Size(739, 315);
            this.ChalangeResultPanel.TabIndex = 4;
            this.ChalangeResultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChalangeResultPanel_Paint);
            // 
            // Java
            // 
            this.Java.AutoSize = true;
            this.Java.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Java.Location = new System.Drawing.Point(69, 164);
            this.Java.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Java.Name = "Java";
            this.Java.Size = new System.Drawing.Size(38, 16);
            this.Java.TabIndex = 5;
            this.Java.Text = "java";
            this.Java.Click += new System.EventHandler(this.Java_Click);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(195, 164);
            this.C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(34, 16);
            this.C.TabIndex = 6;
            this.C.Text = "C++";
            // 
            // Ruby
            // 
            this.Ruby.AutoSize = true;
            this.Ruby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ruby.Location = new System.Drawing.Point(283, 164);
            this.Ruby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ruby.Name = "Ruby";
            this.Ruby.Size = new System.Drawing.Size(44, 16);
            this.Ruby.TabIndex = 7;
            this.Ruby.Text = "Ruby";
            this.Ruby.Click += new System.EventHandler(this.Ruby_Click);
            // 
            // C_Sharp
            // 
            this.C_Sharp.AutoSize = true;
            this.C_Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Sharp.Location = new System.Drawing.Point(369, 164);
            this.C_Sharp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_Sharp.Name = "C_Sharp";
            this.C_Sharp.Size = new System.Drawing.Size(26, 16);
            this.C_Sharp.TabIndex = 8;
            this.C_Sharp.Text = "C#";
            // 
            // LanguageChallangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.C_Sharp);
            this.Controls.Add(this.Ruby);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Java);
            this.Controls.Add(this.ChalangeResultPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compare);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LanguageChallangeControl";
            this.Size = new System.Drawing.Size(745, 566);
            this.Load += new System.EventHandler(this.ChallangeResultControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel ChalangeResultPanel;
        private System.Windows.Forms.Label Java;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label Ruby;
        private System.Windows.Forms.Label C_Sharp;
    }
}
