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
            this.FirstLanguage = new System.Windows.Forms.Label();
            this.SecondLanguage = new System.Windows.Forms.Label();
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
            this.Compare.Location = new System.Drawing.Point(444, 309);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(100, 25);
            this.Compare.TabIndex = 0;
            this.Compare.Text = "Compare";
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // FirstLanguage
            // 
            this.FirstLanguage.AutoSize = true;
            this.FirstLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLanguage.Location = new System.Drawing.Point(104, 145);
            this.FirstLanguage.Name = "FirstLanguage";
            this.FirstLanguage.Size = new System.Drawing.Size(35, 25);
            this.FirstLanguage.TabIndex = 1;
            this.FirstLanguage.Text = "c#";
            this.FirstLanguage.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SecondLanguage
            // 
            this.SecondLanguage.AutoSize = true;
            this.SecondLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLanguage.Location = new System.Drawing.Point(843, 145);
            this.SecondLanguage.Name = "SecondLanguage";
            this.SecondLanguage.Size = new System.Drawing.Size(52, 25);
            this.SecondLanguage.TabIndex = 2;
            this.SecondLanguage.Text = "java";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "VS";
            // 
            // ChalangeResultPanel
            // 
            this.ChalangeResultPanel.Location = new System.Drawing.Point(4, 386);
            this.ChalangeResultPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChalangeResultPanel.Name = "ChalangeResultPanel";
            this.ChalangeResultPanel.Size = new System.Drawing.Size(1108, 485);
            this.ChalangeResultPanel.TabIndex = 4;
            this.ChalangeResultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChalangeResultPanel_Paint);
            // 
            // Java
            // 
            this.Java.AutoSize = true;
            this.Java.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Java.Location = new System.Drawing.Point(220, 251);
            this.Java.Name = "Java";
            this.Java.Size = new System.Drawing.Size(52, 25);
            this.Java.TabIndex = 5;
            this.Java.Text = "java";
            this.Java.Click += new System.EventHandler(this.Java_Click);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(408, 251);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(54, 25);
            this.C.TabIndex = 6;
            this.C.Text = "C++";
            // 
            // Ruby
            // 
            this.Ruby.AutoSize = true;
            this.Ruby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ruby.Location = new System.Drawing.Point(540, 251);
            this.Ruby.Name = "Ruby";
            this.Ruby.Size = new System.Drawing.Size(61, 25);
            this.Ruby.TabIndex = 7;
            this.Ruby.Text = "Ruby";
            this.Ruby.Click += new System.EventHandler(this.Ruby_Click);
            // 
            // C_Sharp
            // 
            this.C_Sharp.AutoSize = true;
            this.C_Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Sharp.Location = new System.Drawing.Point(670, 251);
            this.C_Sharp.Name = "C_Sharp";
            this.C_Sharp.Size = new System.Drawing.Size(40, 25);
            this.C_Sharp.TabIndex = 8;
            this.C_Sharp.Text = "C#";
            // 
            // LanguageChallangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.C_Sharp);
            this.Controls.Add(this.Ruby);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Java);
            this.Controls.Add(this.ChalangeResultPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondLanguage);
            this.Controls.Add(this.FirstLanguage);
            this.Controls.Add(this.Compare);
            this.Name = "LanguageChallangeControl";
            this.Size = new System.Drawing.Size(1118, 871);
            this.Load += new System.EventHandler(this.ChallangeResultControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Compare;
        private System.Windows.Forms.Label FirstLanguage;
        private System.Windows.Forms.Label SecondLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel ChalangeResultPanel;
        private System.Windows.Forms.Label Java;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label Ruby;
        private System.Windows.Forms.Label C_Sharp;
    }
}
