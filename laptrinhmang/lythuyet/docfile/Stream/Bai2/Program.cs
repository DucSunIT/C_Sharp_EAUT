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
            string path = @"D:\C#\laptrinhmang\lythuyet\Stream\myText.txt";

            // nếu mà flie k tồn tại
            if (!File.Exists(path)){
                Console.WriteLine("Path " + path + " do not exists !");
                return;
            }

            // tạo một đối tượng Stream thông qua constructor của FileStream
            // FileMode.Open: mở file để đọc
            Stream stream = new FileStream(path, FileMode.Open);
            byte[] temp = new byte[100];
            UTF8Encoding encoding = new UTF8Encoding(true);
            int len = 0;

            // đọc các phần tử của stream và gán vào mảng của mảng temp 
            // gán vào vị trí thứ 0 và mỗi lần đọc tối đa temp.Lenght phần tử
            // đồng thời trả về số byte vừa đọc 
            // đọc dữ liệu từ file vào mảng temp bắt đầu từ vị trí thứ 0 và đọc tối đã temp.Lenght(100)
            
            while((len = stream.Read(temp, 0, temp.Length))>0)
            {
                string s = encoding.GetString(temp, 0, len);
                Console.Write(s);
            }
            Console.ReadLine();
        }
    }
}
