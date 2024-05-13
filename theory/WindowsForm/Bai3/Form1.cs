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

        private void btnDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn tải xuống tệp tin virus", "Download Virus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát",
            //    "Confirm Exit", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);
            //if(result == DialogResult.Yes)
            //{
            //    Close();
            //}else
            //{
            //    MessageBox.Show("Mời bạn sử dụng tiếp phần mềm ");
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát", "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }else e.Cancel = true;
        }
    }
}
