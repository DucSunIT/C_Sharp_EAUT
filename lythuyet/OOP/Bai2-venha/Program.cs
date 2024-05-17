using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_venha
{
    class NhanVien
    {
        string hoTen; // null
        int tuoi; // 0
        string diaChi;
        double luongCoBan;
        double heSo;
        double phuCap;
        

        public double tienLuong()
        {
            return luongCoBan * heSo + phuCap;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhập họ tên : ");
            nv.hoTen = Console.ReadLine();
            Console.WriteLine("Nhập tuổi : ");
            nv.tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập địa chỉ: ");
            nv.diaChi = Console.ReadLine();
            Console.WriteLine("Nhập lương cơ bản: ");
            nv.luongCoBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số: ");
            nv.heSo = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phụ cấp: ");
            nv.phuCap = double.Parse(Console.ReadLine());

            Console.WriteLine("Tiền lương: " + nv.tienLuong() +" tr");
            Console.ReadLine();
        }
    }
}
