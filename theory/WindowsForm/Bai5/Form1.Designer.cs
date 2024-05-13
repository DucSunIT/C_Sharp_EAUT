namespace Bai5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.chkDaBong = new System.Windows.Forms.CheckBox();
            this.chkNhay = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.chkLapTrinh);
            this.groupBox1.Controls.Add(this.chkNhay);
            this.groupBox1.Controls.Add(this.chkDaBong);
            this.groupBox1.Controls.Add(this.chkDuLich);
            this.groupBox1.Controls.Add(this.chkNgheNhac);
            this.groupBox1.Controls.Add(this.chkXemPhim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(81, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(415, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở Thích";
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(26, 49);
            this.chkXemPhim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(160, 30);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem Phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(26, 86);
            this.chkNgheNhac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(169, 30);
            this.chkNgheNhac.TabIndex = 1;
            this.chkNgheNhac.Text = "Nghe Nhạc";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(26, 124);
            this.chkDuLich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(133, 30);
            this.chkDuLich.TabIndex = 2;
            this.chkDuLich.Text = "Du Lịch";
            this.chkDuLich.UseVisualStyleBackColor = true;
            // 
            // chkDaBong
            // 
            this.chkDaBong.AutoSize = true;
            this.chkDaBong.Location = new System.Drawing.Point(26, 162);
            this.chkDaBong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDaBong.Name = "chkDaBong";
            this.chkDaBong.Size = new System.Drawing.Size(142, 30);
            this.chkDaBong.TabIndex = 3;
            this.chkDaBong.Text = "Đá Bóng";
            this.chkDaBong.UseVisualStyleBackColor = true;
            // 
            // chkNhay
            // 
            this.chkNhay.AutoSize = true;
            this.chkNhay.Location = new System.Drawing.Point(26, 201);
            this.chkNhay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNhay.Name = "chkNhay";
            this.chkNhay.Size = new System.Drawing.Size(100, 30);
            this.chkNhay.TabIndex = 4;
            this.chkNhay.Text = "Nhảy";
            this.chkNhay.UseVisualStyleBackColor = true;
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(26, 240);
            this.chkLapTrinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.Size = new System.Drawing.Size(153, 30);
            this.chkLapTrinh.TabIndex = 5;
            this.chkLapTrinh.Text = "Lập Trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(883, 479);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 69);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(539, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(415, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới Tính ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Famale";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.CheckBox chkNhay;
        private System.Windows.Forms.CheckBox chkDaBong;
        private System.Windows.Forms.CheckBox chkDuLich;
        private System.Windows.Forms.CheckBox chkNgheNhac;
        private System.Windows.Forms.CheckBox chkXemPhim;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

