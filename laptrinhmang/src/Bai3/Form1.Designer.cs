namespace Bai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFIileName = new System.Windows.Forms.TextBox();
            this.txtContentFile = new System.Windows.Forms.TextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội Dung File";
            // 
            // txtFIileName
            // 
            this.txtFIileName.Location = new System.Drawing.Point(74, 36);
            this.txtFIileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFIileName.Name = "txtFIileName";
            this.txtFIileName.Size = new System.Drawing.Size(357, 27);
            this.txtFIileName.TabIndex = 2;
            // 
            // txtContentFile
            // 
            this.txtContentFile.Location = new System.Drawing.Point(74, 98);
            this.txtContentFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContentFile.Multiline = true;
            this.txtContentFile.Name = "txtContentFile";
            this.txtContentFile.Size = new System.Drawing.Size(357, 74);
            this.txtContentFile.TabIndex = 3;
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWriteFile.Location = new System.Drawing.Point(74, 196);
            this.btnWriteFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(107, 41);
            this.btnWriteFile.TabIndex = 4;
            this.btnWriteFile.Text = "Ghi File";
            this.btnWriteFile.UseVisualStyleBackColor = false;
            this.btnWriteFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDocFile.Location = new System.Drawing.Point(201, 196);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(107, 41);
            this.btnDocFile.TabIndex = 5;
            this.btnDocFile.Text = "Đọc File ";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(324, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(504, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtContentFile);
            this.Controls.Add(this.txtFIileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFIileName;
        private System.Windows.Forms.TextBox txtContentFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button button1;
    }
}

