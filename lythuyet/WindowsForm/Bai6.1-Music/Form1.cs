using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Bai6._1_Music
{
    public partial class frmNgheNhac : Form
    {
        private SoundPlayer playMusic;
        public frmNgheNhac()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radBai1.Checked == true)
            {
                    playMusic.Stop();
            }else if (radBai2.Checked == true)
            {
                playMusic.Stop();
            }else if (radBai3.Checked == true)
            {
                playMusic.Stop();
            }else if(radBai4.Checked == true)
            {
                playMusic.Stop();
            }else if (radBai5.Checked == true)
            {
                playMusic.Stop();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBai4.Checked == true)
            {
                playMusic = new SoundPlayer(@"C:\Users\alex_duc\Downloads\Music\laychong.wav");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radBai1.Checked == true)
            {
                playMusic.Play();
            }else if (radBai2.Checked == true)
            {
                playMusic.Play();
            }else if(radBai3.Checked == true)
            {
                playMusic.Play();
            }else if (radBai4.Checked == true)
            {
                playMusic.Play();
            }else if(radBai5.Checked == true)
            {
                playMusic.Play();
            }
            
            
        }

        private void radBai1_CheckedChanged(object sender, EventArgs e)
        {
            if (radBai1.Checked == true)
            {
                playMusic = new SoundPlayer("neulaanh.wav");
            }
        }

        private void radBai2_CheckedChanged(object sender, EventArgs e)
        {
            if(radBai2.Checked == true)
            {
                playMusic = new SoundPlayer("lecay3.wav");
            }
        }

        private void radBai3_CheckedChanged(object sender, EventArgs e)
        {
            if (radBai3.Checked == true)
            {
                playMusic = new SoundPlayer("lanhngonhan.wav");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radBai5_CheckedChanged(object sender, EventArgs e)
        {
            if(radBai5.Checked == true)
            {
                playMusic = new SoundPlayer("xinloi.wav");
            }
        }
    }
}
