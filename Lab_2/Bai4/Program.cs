using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        /*
         * Coder by DucSunIT
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c;
            Console.WriteLine("Nhập cạnh 1: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh 2: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh 3: ");
            c = double.Parse(Console.ReadLine());

            if((a>0) && (b>0) && (c>0) && (a+b>c) &&(a+c>b) && (b + c > a))
            {
                if((a*a + b*b == c*c) || (a*a + c*c ==b*b) || (b*b + c * c == a * a))
                {
                    Console.WriteLine("Tam giác vuông");
                }else if(a==b && b == c)
                {
                    Console.WriteLine("Tam giác đều");
                }else if(a==b || b==c || a == c)
                {
                    Console.WriteLine("Tam giác cân");
                }
                else
                {
                    Console.WriteLine("Tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh nhập vào không phải tam giác !");
            }
            Console.ReadLine();
        }
    }
}
