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
            Console.OutputEncoding = Encoding.UTF8;
            TamGiac tg = new TamGiac();

            // tính diện tích tam giác theo 3 cạnh 
            Console.WriteLine("Nhập cạnh 1 : ");
            tg.Canh1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh 2 : ");
            tg.Canh2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh 3 : ");
            tg.Canh3 = double.Parse(Console.ReadLine());

            // tính diện tích tam giác theo chiều cao + cạnh đáy 
            Console.WriteLine("Nhập chiều cao tam giác: ");
            tg.ChieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh đáy: ");
            tg.CanhDay = double.Parse(Console.ReadLine());

            double res1 = tg.tinhDienTich(tg.Canh1, tg.Canh2, tg.Canh3);
            double res2 = tg.tinhDienTich(tg.ChieuCao, tg.CanhDay);

            Console.WriteLine("Diện tích tam giác theo 3 cạnh : " + res1);
            Console.WriteLine("Diện tích tam giác theo chiều cao, cạnh đáy : " + res2);
            Console.ReadLine();

        }
    }
}
