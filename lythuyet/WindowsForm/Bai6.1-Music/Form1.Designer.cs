namespace Bai6._1_Music
{
    partial class frmNgheNhac
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
            this.lblTiTle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBai5 = new System.Windows.Forms.RadioButton();
            this.radBai4 = new System.Windows.Forms.RadioButton();
            this.radBai3 = new System.Windows.Forms.RadioButton();
            this.radBai2 = new System.Windows.Forms.RadioButton();
            this.radBai1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTiTle
            // 
            this.lblTiTle.Location = new System.Drawing.Point(64, 26);
            this.lblTiTle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTiTle.Name = "lblTiTle";
            this.lblTiTle.Size = new System.Drawing.Size(498, 25);
            this.lblTiTle.TabIndex = 0;
            this.lblTiTle.Text = "Phần Mềm Nghe Nhạc Nạp VIP";
            this.lblTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radBai5);
            this.groupBox1.Controls.Add(this.radBai4);
            this.groupBox1.Controls.Add(this.radBai3);
            this.groupBox1.Controls.Add(this.radBai2);
            this.groupBox1.Controls.Add(this.radBai1);
            this.groupBox1.Location = new System.Drawing.Point(58, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(348, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhạc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radBai5
            // 
            this.radBai5.AutoSize = true;
            this.radBai5.Location = new System.Drawing.Point(11, 189);
            this.radBai5.Margin = new System.Windows.Forms.Padding(5);
            this.radBai5.Name = "radBai5";
            this.radBai5.Size = new System.Drawing.Size(260, 29);
            this.radBai5.TabIndex = 4;
            this.radBai5.TabStop = true;
            this.radBai5.Text = "Xin Lỗi Vì Đã Xuất Hiện";
            this.radBai5.UseVisualStyleBackColor = true;
            this.radBai5.CheckedChanged += new System.EventHandler(this.radBai5_CheckedChanged);
            // 
            // radBai4
            // 
            this.radBai4.AutoSize = true;
            this.radBai4.Location = new System.Drawing.Point(11, 150);
            this.radBai4.Margin = new System.Windows.Forms.Padding(5);
            this.radBai4.Name = "radBai4";
            this.radBai4.Size = new System.Drawing.Size(329, 29);
            this.radBai4.TabIndex = 3;
            this.radBai4.TabStop = true;
            this.radBai4.Text = "Ngày Mai Người Ta Lấy Chồng";
            this.radBai4.UseVisualStyleBackColor = true;
            this.radBai4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radBai3
            // 
            this.radBai3.AutoSize = true;
            this.radBai3.Location = new System.Drawing.Point(10, 111);
            this.radBai3.Margin = new System.Windows.Forms.Padding(5);
            this.radBai3.Name = "radBai3";
            this.radBai3.Size = new System.Drawing.Size(204, 29);
            this.radBai3.TabIndex = 2;
            this.radBai3.TabStop = true;
            this.radBai3.Text = "Là Anh Ngộ Nhận";
            this.radBai3.UseVisualStyleBackColor = true;
            this.radBai3.CheckedChanged += new System.EventHandler(this.radBai3_CheckedChanged);
            // 
            // radBai2
            // 
            this.radBai2.AutoSize = true;
            this.radBai2.Location = new System.Drawing.Point(10, 72);
            this.radBai2.Margin = new System.Windows.Forms.Padding(5);
            this.radBai2.Name = "radBai2";
            this.radBai2.Size = new System.Drawing.Size(120, 29);
            this.radBai2.TabIndex = 1;
            this.radBai2.TabStop = true;
            this.radBai2.Text = "Lệ Cay 3";
            this.radBai2.UseVisualStyleBackColor = true;
            this.radBai2.CheckedChanged += new System.EventHandler(this.radBai2_CheckedChanged);
            // 
            // radBai1
            // 
            this.radBai1.AutoSize = true;
            this.radBai1.Location = new System.Drawing.Point(10, 33);
            this.radBai1.Margin = new System.Windows.Forms.Padding(5);
            this.radBai1.Name = "radBai1";
            this.radBai1.Size = new System.Drawing.Size(147, 29);
            this.radBai1.TabIndex = 0;
            this.radBai1.TabStop = true;
            this.radBai1.Text = "Nếu Là Anh";
            this.radBai1.UseVisualStyleBackColor = true;
            this.radBai1.CheckedChanged += new System.EventHandler(this.radBai1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(416, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bắt Đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(416, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dừng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(416, 258);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmNgheNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(607, 334);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTiTle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNgheNhac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Nghe Nhạc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTiTle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radBai5;
        private System.Windows.Forms.RadioButton radBai4;
        private System.Windows.Forms.RadioButton radBai3;
        private System.Windows.Forms.RadioButton radBai2;
        private System.Windows.Forms.RadioButton radBai1;
    }
}

