using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class HinhChuNhat: Shape
    {
        // tính chu vi
        public double chuVi(double chieuDai, double chieuRong)
        {
            return (chieuDai + chieuRong) * 2;
        }
    }
}
