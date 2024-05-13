using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._1_Baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblKetQua.Text = txtNhapTen.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.Font = new Font(
               lblKetQua.Font.Name,
               lblKetQua.Font.Size,
               lblKetQua.Font.Style ^ FontStyle.Italic);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.ForeColor = radRed.ForeColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
                lblKetQua.ForeColor = radGreen.ForeColor;
        }
        

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.ForeColor=radBlue.ForeColor;
        }

        private void radYellow_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.ForeColor=radYellow.ForeColor;
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.Font = new Font(
                lblKetQua.Font.Name,
                lblKetQua.Font.Size,
                lblKetQua.Font.Style^FontStyle.Bold);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblKetQua.Font = new Font(
               lblKetQua.Font.Name,
               lblKetQua.Font.Size,
               lblKetQua.Font.Style ^ FontStyle.Underline);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn reset",
                "Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txtNhapTen.Text = "";
                lblKetQua.Text = "Coder by AlexDuc";
                radRed.Checked = true;
                chkInDam.Checked = false;
                chkInNghieng.Checked = false;
                chkGachChan.Checked = false;
            }
        }
    }
}
