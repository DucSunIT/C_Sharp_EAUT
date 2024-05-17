using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\laptrinhmang\lythuyet\Stream\myText.txt";

            // tạo một thư mục cha 
            Directory.CreateDirectory(@"D:\C#\laptrinhmang\lythuyet\Stream\");

            // tạo một đối tượng Stream thông qua constructor  FileStream
            // File.Create: Tạo file mới để ghi, nếu file tồn tại thì ghi đè file
            Stream stream = new FileStream(path, FileMode.Create);

            try
            {
                // Một mảng các byte ( 1 byte < 2^8)
                //byte[] bytes = new byte[]{72,101,108,108,111,32,87,111,114,100};
                string s = "Phạm Tiến Đức";
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                if (stream.CanWrite)
                {
                    stream.Write(bytes, 0, bytes.Length);

                    // ghi thêm một byte 33 ->!
                    stream.WriteByte(33);
                }
            }catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }
            finally
            {
                // đóng Stream để giải phóng tài nguyên 
                stream.Close();
            }
            Console.WriteLine("Success !");
            Console.ReadLine();
        }
    }
}
