using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // vẽ tam giác vuông đặc 
            int n;
            Console.Write("Nhập n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("->Tam giác vuông đặc");
            for (int i = 1; i <= n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("->Tam giác vuông rỗng");

            // vẽ tam giác vuông rỗng 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || i==n || j==1 || i == j)
                    {
                        Console.Write("* ");
                    }else Console.Write("  ");
                }
                Console.WriteLine();
            }

            // vẽ hình vuông rỗng
            Console.WriteLine("->Hình vuông rỗng");

     
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == n)
                    {
                        Console.Write("* ");
                    }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
