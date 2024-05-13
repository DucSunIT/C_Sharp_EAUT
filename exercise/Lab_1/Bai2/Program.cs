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
            const double PI = 3.14;
            int chieuCao, banKinh;
            double dienTichXungQuanh, theTich;
            Console.Write("Nhập chiều cao: ");
            chieuCao = int.Parse(Console.ReadLine());
            Console.Write("Nhập bán kính: ");
            banKinh = int. Parse(Console.ReadLine());
            dienTichXungQuanh = 2 * PI * banKinh * chieuCao;
            theTich = PI * banKinh * banKinh * chieuCao;
            Console.WriteLine("Diên tích xung quanh : {0}", dienTichXungQuanh);
            Console.WriteLine("Thể tích : {0}", theTich);
            Console.ReadLine();
        }
    }
}
