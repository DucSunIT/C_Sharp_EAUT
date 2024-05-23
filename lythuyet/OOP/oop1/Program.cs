using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class Program
    {
 

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SinhVien sinhVien = new SinhVien(1, "Alex");
            //Console.WriteLine(sinhVien.MaSinhVien);
            //Console.WriteLine(sinhVien.HoTen);

            SinhVien sinhVien2 = new SinhVien();
            sinhVien2.MaSinhVien = 20220984;
            sinhVien2.HoTen = "Phạm Tiến Đức";
            Console.WriteLine("ID: " + sinhVien2.MaSinhVien);
            Console.WriteLine("Full name: " + sinhVien2.HoTen);

            // toString
            //Console.WriteLine(sinhVien.ToString());

            // overrloading
            //Console.WriteLine(sinhVien.Sum(2,3));
            //Console.WriteLine(sinhVien.Sum(2,3,4));
            //Console.WriteLine(sinhVien.Sum(2.5,3.4,9.8));

            // params
            //Console.WriteLine(sinhVien.TBC(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(sinhVien2.TBC(1,2,3,4,5,6,7,8,9,10, 20.4,9.8,10.5));

            // support method and service method
            SinhVien sinhVien3 = new SinhVien(1, "AlexDuc", 22);
            sinhVien3.thongTin();

            // Auto-Implement 
            HocSinh hocSinh = new HocSinh();
            hocSinh.maSinhVien = 20220984;
            hocSinh.hoTen = "Alex Duc";
            hocSinh.lop = "DCCNTT13.10.6";
            Console.WriteLine(hocSinh.ToString());

        }
    }
}
