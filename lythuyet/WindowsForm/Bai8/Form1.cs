using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // thêm phần tử vào listbox
            lstList.Items.Add("Item 4");
            lstList.Items.Add("Item 5");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // đếm số lượng phần tử trong listbox
            int count = lstList.Items.Count;
            MessageBox.Show("Số lượng phần tử trong list box là : " + count);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            // xuất phần tử ở vị trí index 
            MessageBox.Show("Phần tử index 0 trong list là : " + lstList.Items[0].ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // xóa phần tử theo vị trí index
            lstList.Items.RemoveAt(1);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           // trả về danh sách vị trí của các phần tử đang được chọn
           foreach(int i in lstList.SelectedIndices)
            {
                Console.WriteLine(i);
            }
           // trả về giá trị index của phần tủ đầu tiên đang được chọn 
            Console.WriteLine(lstList.SelectedIndices[0]);
            // trả về số lượng phần tử đang được chọn
            Console.WriteLine(lstList.SelectedIndices.Count);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // gọi phần tử tại vị trí index và thay đổi giá trị của nó
            lstList.Items[0] = "Hello World !";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // trả về vị trí của các item đang được chọn nếu không có item nào được chọn thì trả về -1
            // nếu có nhiều item được chọn trả về index bé nhất 
            MessageBox.Show("Index số được chọn là : " + lstList.SelectedIndex);
        }
    }
}
