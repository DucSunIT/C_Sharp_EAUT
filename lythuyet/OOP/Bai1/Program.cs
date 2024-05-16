using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1
{
    public class SinhVien
    {
        int maSinhVien;
        string hoTen;
        string lop;
        double lapTrinhNet;
        double CNPM;
        double PTTK;

        double diemTrungBinh()
        {
            return (lapTrinhNet + CNPM + PTTK) / 3;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            Console.WriteLine("Nhập mã sinh viên");
            sv.maSinhVien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên: ");
            sv.hoTen = Console.ReadLine();
            Console.WriteLine("Nhập lớp: ");
            sv.lop = Console.ReadLine();
            Console.WriteLine("Nhập điểm Lập trình NET: ");
            sv.lapTrinhNet = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm CNPM:");
            sv.CNPM = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm PTTK : ");
            sv.PTTK = double.Parse(Console.ReadLine());

            // method
            Console.WriteLine("Điểm trung bình : " + sv.diemTrungBinh());
            Console.ReadLine();
        }
    }
    
   
}
