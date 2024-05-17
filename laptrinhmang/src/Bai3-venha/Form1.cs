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
namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFIileName.Text + ".txt";
            string contentFile = txtContentFile.Text;
            File.WriteAllText(fileName, contentFile);
            MessageBox.Show("Bạn đã ghi file thành công");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docFile = File.ReadAllText(txtFIileName.Text + ".txt");
            txtContentFile.Text = docFile;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
