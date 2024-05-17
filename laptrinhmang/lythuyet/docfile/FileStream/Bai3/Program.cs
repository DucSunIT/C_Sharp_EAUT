using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\laptrinhmang\lythuyet\Bai1\myText.txt";
            
            if (!File.Exists(path))
            {
                Console.WriteLine("Error " + path + " do not exists !");
                return;

                // đảm bảo thư mục cha tồn tại 
                Directory.CreateDirectory(@"D:\C#\laptrinhmang\lythuyet\");
            }
            // ghi nối tiếp vào vị trí cuối cùng 
            FileStream fileStream = new FileStream(path, FileMode.Append);

            string s = "\nHello World !";
            // chuyển một chuỗi thành mảng các byte theo ký tự ASCII
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            // ghi các byte xuống file 
            fileStream.Write(bytes, 0, bytes.Length);

            Console.WriteLine("Success");
            Console.ReadLine(); 
        }
    }
}
