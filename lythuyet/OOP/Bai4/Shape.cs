using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Shape
    {
        
        public double canh1 { get; set; }
        public double canh2 { get; set; }

        // constructor
        public Shape(double canh1 , double canh2)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
        }
        public virtual double tinhDienTich()
        {
            return 0;
        }

        
        public class HinhChuNhat : Shape
        {
            public HinhChuNhat(double canh1, double canh2):base(canh1, canh2)
            {

            }
            public override double tinhDienTich()
            {
                base.tinhDienTich();
                return this.canh1 * this.canh2;
            }
        }

        public class HinhTamGiac : Shape
        {
            public HinhTamGiac(double canh1, double canh2) : base(canh1, canh2)
            {

            }
            public override double tinhDienTich()
            {
                base.tinhDienTich();
                return this.canh2 * this.canh2 * 0.5;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HinhChuNhat hcn = new HinhChuNhat(4,5);
            HinhTamGiac tg = new HinhTamGiac(5,8);

            Console.WriteLine("Diện tích hình chữ nhật : " + hcn.tinhDienTich());
            Console.WriteLine("Diện tích hình tam giác : " + tg.tinhDienTich());
        }
    }
}
