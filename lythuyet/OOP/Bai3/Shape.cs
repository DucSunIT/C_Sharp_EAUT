using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Shape
    {
        private double chieuRong;
        private double chieuDai;

        // get set 
        public double ChieuRong
        {
            get { return this.chieuRong; }
            set
            {
                this.chieuRong = value;
            }

        }

        public double ChieuDai
        {
            get { return this.chieuDai; }
            set
            {
                this.chieuDai = value;
            }

        }

        // method
        public double tinhDienTich(double chieuRong, double chieuDai)
        {
            return chieuDai * chieuRong;
        }
    }

    
}
