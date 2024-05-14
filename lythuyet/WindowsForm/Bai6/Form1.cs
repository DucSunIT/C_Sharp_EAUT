using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // thêm thư viện Media
namespace Bai6
{
    public partial class frmFitness : Form
    {
        private SoundPlayer playMusic;
        public frmFitness()
        {
            InitializeComponent();
            // tệp video phải ở dạng wav
            playMusic = new SoundPlayer("nhactap.wav");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true) playMusic.Play();
            else playMusic.Stop();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (picHaTa.Visible == false)
            {
                btnCount.Text = textInput.Text + " ! Click để Hạ tạ";
            }
            else
            {
                btnCount.Text = textInput.Text + " ! Click để Nâng tạ";
            }
        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (picHaTa.Visible == false)
            {
                picHaTa.Visible = true;
                picNangTa.Visible = false;
                btnCount.Text = btnCount.Text.Replace("Hạ", "Nâng");
                lblResult.Text = count.ToString();
                ++count;
                if (count == 11)
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn đã tập đủ ngày hôm nay, bạn có muốn tập tiếp không",
                        "Confirm Fitness",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if(result != DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            else
            {
                picHaTa.Visible = false;
                picNangTa.Visible = true;
                btnCount.Text = btnCount.Text.Replace("Nâng","Hạ");
            }
        }

        private void picNangTa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picHaTa.Visible = false;
        }

        private void frmFitness_Load(object sender, EventArgs e)
        {
            picHaTa.Visible=false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
