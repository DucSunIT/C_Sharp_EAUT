using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = "test.txt";
            string contentfile = "Xin chào! xuanthulab.net ";
            File.WriteAllText(filename, contentfile);

            contentfile = "\n toi di hoc day";
            File.AppendAllText(filename, contentfile);
            Console.WriteLine($"ghi file thanh cong");

        }
    }
}
