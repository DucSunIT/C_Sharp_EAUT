using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        enum number
        {
            Khong,
            Mot,
            Hai,
            Ba,
            Bon,
            Nam,
            Sau,
            Bay,
            Tam,
            Chin
        }
        static void Main(string[] args)
        {
        loop:
            int soNhap;
            Console.OutputEncoding = Encoding.UTF8;
            // nhập số khoảng từ 0 -> 99
            Console.Write("Nhập số: ");
            soNhap = int.Parse(Console.ReadLine());
            if ((soNhap < 0) || (soNhap > 99))
            {
                Console.WriteLine("Bạn vui lòng nhập số trong khoảng 0 đến 99 !");
                goto loop;
            }
            int chuSoHangChuc = soNhap / 10; // lấy ra chữ số hàng chục
            int chuSoHangDonVi = soNhap % 10; // lấy ra chữ số hàng đơn vị

            string cachDoc = "";
            switch ((number)chuSoHangChuc)
            {
                case number.Khong: break;
                case number.Mot:
                    cachDoc += "Mười";
                    break;
                case number.Hai:
                    cachDoc += "Hai Mươi";
                    break;
                case number.Ba:
                    cachDoc += "Ba Mươi";
                    break;
                case number.Bon:
                    cachDoc += "Bốn Mươi";
                    break;
                case number.Nam:
                    cachDoc += "Năm Mươi";
                    break;
                case number.Sau:
                    cachDoc += "Sáu Mươi";
                    break;
                case number.Bay:
                    cachDoc += "Bảy Mươi";
                    break;
                case number.Tam:
                    cachDoc += "Tám Mươi";
                    break;
                case number.Chin:
                    cachDoc += "Chín Mươi";
                    break;
                default:
                    Console.WriteLine("ERROR !");
                    break;

            }

            switch ((number)chuSoHangDonVi)
            {
                case number.Khong:
                    if (chuSoHangChuc == 0)
                    {
                        cachDoc += "Không";
                    }
                    break;
                case number.Mot:
                    cachDoc += " Một";
                    break;
                case number.Hai:
                    cachDoc += " Hai";
                    break;
                case number.Ba:
                    cachDoc += " Ba";
                    break;
                case number.Bon:
                    cachDoc += " Bốn";
                    break;
                case number.Nam:
                    cachDoc += " Năm";
                    break;
                case number.Sau:
                    cachDoc += " Sáu";
                    break;
                case number.Bay:
                    cachDoc += " Bảy";
                    break;
                case number.Tam:
                    cachDoc += " Tám";
                    break;
                case number.Chin:
                    cachDoc += " Chín";
                    break;

            }
            Console.Write("Cách đọc số {0} là : {1} ", soNhap, cachDoc);
            Console.ReadLine();
        }
    }
}
