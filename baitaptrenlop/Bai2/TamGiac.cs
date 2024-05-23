using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class TamGiac
    {
        #region khai báo biến
        private double canh1;
        private double canh2;
        private double canh3;
        private double chieuCao;
        private double canhDay;
        #endregion

        #region thuộc tính get set 
        // canh 1
        public double Canh1
        {
            get { return this.canh1; }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Nhập cạnh > 0");
                    value = double.Parse(Console.ReadLine());
                }
                this.canh1 = value;
            }
        }


        // canh 3
        public double Canh2
        {
            get { return canh2; }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Nhập cạnh > 0");
                    value = double.Parse(Console.ReadLine());
                }
                this.canh2 = value;
            }
        }


        // canh 3
        public double Canh3
        {
            get { return canh3; }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Nhập cạnh > 0");
                    value = double.Parse(Console.ReadLine());
                }
                this.canh3 = value;
            }
        }

        // chieu cao
        public double ChieuCao
        {
            get { return this.chieuCao; }
            set
            {
                this.chieuCao = value;
            }
        }
        public double CanhDay
        {
            get { return this.canhDay; }
            set
            {
                this.canhDay = value;
            }


        }
        #endregion

        #region phương thức 
        // method 
        public double tinhDienTich(double canh1, double canh2, double canh3)
        {
            // tính nửa chu vi 
            double p = (canh1 + canh2 + canh3) / 2;
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }

        public double tinhDienTich(double chieuCao, double canhDay)
        {
            return 0.5 * canhDay * chieuCao;
        }
        #endregion
    }
}
