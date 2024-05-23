using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class NhanVien
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.MaNhanVien = 1;
            nv1.TenNhanVien = "Nhân viên 1";
            Console.WriteLine("Mã nhân viên : " + nv1.MaNhanVien + " tên nhân viên : " + nv1.TenNhanVien);
            // kế thừa phương thức 
            Console.WriteLine("Lương của nhân viên : " + nv1.TinhLuong());
            Console.WriteLine("-------------");

            // class NhanVienHanhChinh
            NhanVienHanhChinh nvhc = new NhanVienHanhChinh();
            nvhc.MaNhanVien = 2;
            nvhc.TenNhanVien = "Nhân viên hành chính";
            Console.WriteLine("Mã nhân viên : " + nvhc.MaNhanVien + " tên nhân viên : " + nvhc.TenNhanVien);
            // kế thừa phương thức 

            Console.WriteLine("Lương của nhân viên : " + nvhc.TinhLuong());
            Console.WriteLine("-------------");

            // class NhanVienDiCa
            NhanVienDiCa nvdc = new NhanVienDiCa();
            nvdc.MaNhanVien = 3;
            nvdc.TenNhanVien = "Nhân viên đi ca";
            nvdc.DiCa = "Ca ngày";
            Console.WriteLine("Mã nhân viên : " + nvdc.MaNhanVien + " tên nhân viên : " + nvdc.TenNhanVien + ", ca làm : " + nvdc.DiCa);
            // kế thừa phương thức 
            Console.WriteLine("Lương của nhân viên : " + nvdc.TinhLuong());
            Console.WriteLine("-------------");

            // ghi đè phương thức
            Console.WriteLine("-----------");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(nvhc.ThuongDuCong(26));
            Console.WriteLine(nvdc.ThuongDuCong(26));

            Console.ReadLine();
        }
    }
}
