using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tạo đối tượng 
            HinhChuNhat hcn = new HinhChuNhat();
            // tính diện tích 
            double dienTich = hcn.tinhDienTich(4, 5);
            // tính chu vi
            double chuVi = hcn.chuVi(5, 6);
            // in kết quả lên console
            Console.WriteLine("Diện tích hình chữ nhật là : " + dienTich);
            Console.WriteLine("Chu vi của hình chữ nhật là : " + chuVi);
            Console.ReadKey();
        }
    }
}
