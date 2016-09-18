namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.IdentifyBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.RenameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.Location = new System.Drawing.Point(446, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 22);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Choose";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(51, 9);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(389, 20);
            this.pathBox.TabIndex = 3;
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // IdentifyBtn
            // 
            this.IdentifyBtn.Location = new System.Drawing.Point(51, 46);
            this.IdentifyBtn.Name = "IdentifyBtn";
            this.IdentifyBtn.Size = new System.Drawing.Size(96, 40);
            this.IdentifyBtn.TabIndex = 4;
            this.IdentifyBtn.Text = "Identify Files";
            this.IdentifyBtn.UseVisualStyleBackColor = true;
            this.IdentifyBtn.Click += new System.EventHandler(this.IdentifyBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(202, 46);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(96, 40);
            this.SortBtn.TabIndex = 5;
            this.SortBtn.Text = "Sort Files";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // RenameBtn
            // 
            this.RenameBtn.Location = new System.Drawing.Point(344, 46);
            this.RenameBtn.Name = "RenameBtn";
            this.RenameBtn.Size = new System.Drawing.Size(96, 40);
            this.RenameBtn.TabIndex = 6;
            this.RenameBtn.Text = "Rename Files";
            this.RenameBtn.UseVisualStyleBackColor = true;
            this.RenameBtn.Click += new System.EventHandler(this.RenameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 108);
            this.Controls.Add(this.RenameBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.IdentifyBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button IdentifyBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button RenameBtn;
    }
}

