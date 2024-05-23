using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtInput.Text);
            lstList.Items.Add(x);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstList.SelectedIndex = -1;
            for(int i=0; i < lstList.Items.Count; i++)
            {
                int x = (int)lstList.Items[i];
                if(x%2==0) lstList.SelectedIndex = i;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int i in lstList.Items)
            {
                sum += i;
            }
            MessageBox.Show("Tổng của danh sách là: " + sum);
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            lstList.Items.RemoveAt(0);
            lstList.Items.RemoveAt(lstList.Items.Count - 1);
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            while (lstList.SelectedIndex != -1)
            {
                lstList.Items.RemoveAt(lstList.SelectedIndex);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
          
            for(int i=0; i<lstList.Items.Count; i++)
            {
                //Console.WriteLine(i);
                //Console.WriteLine(lstList.Items[i]);
                int x = (int) lstList.Items[i] + 2;
                lstList.Items[i] = x;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lstList.Items.Count; i++)
            {
                //Console.WriteLine(i);
                //Console.WriteLine(lstList.Items[i]);
                int x = (int)lstList.Items[i] * (int)lstList.Items[i];
                lstList.Items[i] = x;
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstList.SelectedIndex = -1;
            for (int i = 0; i < lstList.Items.Count; i++)
            {
                int x = (int)lstList.Items[i];
                if (x % 2 != 0) lstList.SelectedIndex = i;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn kết thúc chương trình",
                "Kết Thúc",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
