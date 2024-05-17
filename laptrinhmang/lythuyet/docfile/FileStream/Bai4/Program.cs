using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding  = Encoding.UTF8;
            string path = @"D:\C#\laptrinhmang\lythuyet\Bai1\myText.txt";

            if(!File.Exists(path))
            {
                Console.WriteLine("File " + path + " do not exists");
                return;
            }
            
            FileStream fileStream = new FileStream(path, FileMode.Open);
            byte[] bytes = new byte[100];
            Encoding encoding = Encoding.UTF8;
            int len = 0;
            while((len=fileStream.Read(bytes, 0, bytes.Length)) > 0)
            {
                string s = encoding.GetString(bytes, 0, len);
                Console.WriteLine(s);
            }
            Console.ReadLine();
            
        }
    }
}
