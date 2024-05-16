using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear(); // xóa lỗi 
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Không được để trống");
                check = false;
            }
            // Age 
            // tryPare : ép kiểu nếu false trường tuổi nhập sai , sẽ không Parse
            if (int.TryParse(txtAge.Text, out tuoi) == false)
            {
                errorProvider1.SetError(txtAge, "Sai định dạng");
                check = false;

            }
            else
            {
                if (tuoi < 18)
                {
                    errorProvider1.SetError(txtAge, "Bạn chưa đủ tuổi !");
                    check = false;

                }
            }

            if(dtpDate.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDate, "Thứ hai không chiếu phim nhé !");
                check = false;

            }
            if (check == true)
            {
                MessageBox.Show("Bạn đã đăng kí thành công, chúng tôi sẽ liên hệ với bạn !");
            }
        }
        int tuoi;
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
