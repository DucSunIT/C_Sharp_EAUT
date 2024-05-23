namespace Bai8_baitap1
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.grbList.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(43, 48);
            this.lblNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(90, 20);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập số :";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(141, 45);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(490, 27);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(639, 45);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 27);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.lstList);
            this.grbList.Location = new System.Drawing.Point(47, 89);
            this.grbList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbList.Size = new System.Drawing.Size(338, 355);
            this.grbList.TabIndex = 3;
            this.grbList.TabStop = false;
            this.grbList.Text = "Danh Sách ";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLe);
            this.grbChucNang.Controls.Add(this.btnChan);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTang);
            this.grbChucNang.Controls.Add(this.btnXoa2);
            this.grbChucNang.Controls.Add(this.btnXoa1);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(416, 89);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbChucNang.Size = new System.Drawing.Size(338, 355);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 452);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(707, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Kết Thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstList
            // 
            this.lstList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 20;
            this.lstList.Location = new System.Drawing.Point(4, 24);
            this.lstList.Name = "lstList";
            this.lstList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstList.Size = new System.Drawing.Size(330, 327);
            this.lstList.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(22, 27);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(294, 40);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách ";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(22, 73);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(294, 40);
            this.btnXoa1.TabIndex = 1;
            this.btnXoa1.Text = "Xóa phần tử đầu và cuối";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Location = new System.Drawing.Point(22, 119);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(294, 40);
            this.btnXoa2.TabIndex = 2;
            this.btnXoa2.Text = "Xóa phần tử đang chọn";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(22, 162);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(294, 40);
            this.btnTang.TabIndex = 3;
            this.btnTang.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(22, 208);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(294, 40);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương ";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(22, 254);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(294, 40);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(22, 300);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(294, 40);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "Chọn số lẻ ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(807, 516);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grbList.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnTong;
    }
}

