using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        /*
         * Coder by DucSunIT
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen, diaChi;
            double diemToan, diemTin, diemAnh;
            do
            {
                Console.Write("Nhập họ tên : ");
                hoTen = Console.ReadLine();
                Console.Write("Nhập địa chỉ : ");
                diaChi = Console.ReadLine();
                Console.Write("Nhập điểm toán : ");
                diemToan = int.Parse(Console.ReadLine());
                Console.Write("Nhập điểm tin : ");
                diemTin = int.Parse(Console.ReadLine());
                Console.Write("Nhập điểm anh : ");
                diemAnh = int.Parse(Console.ReadLine());
                if ((diemToan < 0 || diemToan > 10) || (diemTin < 0 || diemTin > 10) || (diemAnh < 0 || diemAnh > 10))
                {
                    Console.WriteLine(">> Các điểm phải lớn hơn 0 và nhỏ hơn 10 !");
                }
            } while ((diemToan < 0 || diemToan > 10) || (diemTin < 0 || diemTin > 10) || (diemAnh < 0 || diemAnh > 10));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(">> Họ tên : " + hoTen);
            Console.WriteLine(">> Địa chỉ: " + diaChi);
            Console.WriteLine(">> Điểm toán : " + diemToan);
            Console.WriteLine(">> Điểm tin : " + diemTin);
            Console.WriteLine(">> Điểm anh : " + diemAnh);
            Console.ReadLine();
        }
    }
}
