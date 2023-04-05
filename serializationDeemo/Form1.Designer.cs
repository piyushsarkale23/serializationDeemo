namespace serializationDeemo
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
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtper = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(214, 227);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 26);
            this.txt3.TabIndex = 0;
            this.txt3.Text = "Percentage";
            this.txt3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(214, 162);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 26);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "name";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(214, 90);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 26);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "rollno";
            // 
            // txtper
            // 
            this.txtper.Location = new System.Drawing.Point(381, 227);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(100, 26);
            this.txtper.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(381, 162);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(381, 90);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(100, 26);
            this.txtroll.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(226, 304);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 43);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(406, 304);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 43);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtroll);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtper);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtper;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
    }
}