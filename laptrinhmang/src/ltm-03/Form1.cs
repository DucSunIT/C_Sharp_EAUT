using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ltm_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            string path = @"D:\C#\laptrinhmang\src\ltm-03\taikhoan.txt";
            string content = username + ";" + password + "\n";

            // Đảm bảo thư mục tồn tại
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                MessageBox.Show("Thư mục không tồn tại.");
                return;
            }

            // Thêm nội dung vào tệp
            File.AppendAllText(path, content);
            MessageBox.Show("Đăng kí thành công!");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
