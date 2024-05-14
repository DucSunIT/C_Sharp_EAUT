using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close(); // thoát khỏi chương trình 
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                long tong = 0;
                // tetxt -> biết được người dùng nhập gì vào 
                tong = long.Parse(txtA.Text) + long.Parse(txtB.Text);
                lblKetQua.Text = txtA.Text + " + " + txtB.Text + " = " + tong + "";
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Empty Value");
            }
            
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            try
            {
                long hieu = 0;
                hieu = long.Parse(txtA.Text) - long.Parse(txtB.Text);
                lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Empty Value");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn reset", 
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                lblKetQua.Text = "Coder by AlexDuc";
                txtA.Text = "";
                txtB.Text = "";
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                long nhan = 1;
                if (long.Parse(txtA.Text) == 0 || long.Parse(txtB.Text) == 0)
                {
                    lblKetQua.Text = "0 nhân cái gì cũng bằng 0 thôi ku !!";
                }
                else
                {
                    nhan = long.Parse(txtA.Text) * long.Parse(txtB.Text);
                    lblKetQua.Text = txtA.Text + " * " + txtB.Text + " = " + nhan + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Empty Value");
            }


        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double chia;
                if (double.Parse(txtB.Text) == 0)
                {
                    lblKetQua.Text = "Không chia được cho số 0 nha ku !";
                }
                else
                {
                    chia = double.Parse(txtA.Text) / double.Parse(txtB.Text);
                    lblKetQua.Text = txtA.Text + " / " + txtB.Text + " = " + chia + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Empty Value");
            }


        }
    }
}
