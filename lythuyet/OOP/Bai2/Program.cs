using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //SinhVien sv1 = new SinhVien();
            //SinhVien sv2 = new SinhVien("12345678", "Sinh Viên 2", "DH01");
            //Console.WriteLine("Thông tin 2 : " + sv2.maSinhVien + " " + sv2.hoTen + " " + sv2.lop);

            Test t = new Test();
            int a = 8, b = 10;
            t.Swap(a, b);
            Console.WriteLine(" a = " + a + " b = " + b);
            t.Swap(ref a, ref b);
            Console.WriteLine(" a = " + a + " b = " + b);
            Console.ReadLine();
        }
    }
}
