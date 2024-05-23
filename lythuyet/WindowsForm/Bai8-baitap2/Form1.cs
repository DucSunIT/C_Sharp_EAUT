using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            if(txtMa.Text == "")
            {
                errorProvider1.SetError(txtMa, "Vui lòng nhập số");
            }
            sv.Ten = txtHoTen.Text;

            string s = sv.Ma + "\t" + sv.Ten;
            lstDanhSach.Items.Add(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa tất cả dữ liệu",
                "Xóa Dữ Liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                // xóa tất cả dữ liệu trong danh sách 
                lstDanhSach.Items.Clear();
                txtMa.Text = "";
                txtHoTen.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
