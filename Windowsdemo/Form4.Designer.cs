namespace Windowsdemo
{
    partial class Form4
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btncreatefolder1 = new System.Windows.Forms.Button();
            this.btncreatefile1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(41, 190);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(149, 190);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter dep id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dep Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dep Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(309, 44);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(118, 23);
            this.btncreatefolder.TabIndex = 9;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(309, 103);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(118, 23);
            this.btncreatefile.TabIndex = 10;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btncreatefolder1
            // 
            this.btncreatefolder1.Location = new System.Drawing.Point(309, 159);
            this.btncreatefolder1.Name = "btncreatefolder1";
            this.btncreatefolder1.Size = new System.Drawing.Size(118, 23);
            this.btncreatefolder1.TabIndex = 11;
            this.btncreatefolder1.Text = "Create Folder1";
            this.btncreatefolder1.UseVisualStyleBackColor = true;
            this.btncreatefolder1.Click += new System.EventHandler(this.btncreatefolder1_Click);
            // 
            // btncreatefile1
            // 
            this.btncreatefile1.Location = new System.Drawing.Point(309, 208);
            this.btncreatefile1.Name = "btncreatefile1";
            this.btncreatefile1.Size = new System.Drawing.Size(118, 23);
            this.btncreatefile1.TabIndex = 12;
            this.btncreatefile1.Text = "Create File 1";
            this.btncreatefile1.UseVisualStyleBackColor = true;
            this.btncreatefile1.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 258);
            this.Controls.Add(this.btncreatefile1);
            this.Controls.Add(this.btncreatefolder1);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form4";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btncreatefolder1;
        private System.Windows.Forms.Button btncreatefile1;
    }
}