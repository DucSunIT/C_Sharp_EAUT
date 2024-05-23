using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai2
{
    public class SinhVien
    {
        #region khai báo biến  
        public string maSinhVien;
        public string hoTen;
        public string lop;
        #endregion

        #region constructor
        // constructor 
        public SinhVien()
        {
            this.maSinhVien = "xxxxxxxx";
            this.hoTen = "Nguyen Van A";
            this.lop = "DCCNTT11.10.1";
            Console.WriteLine("Thông tin 1 : " + this.maSinhVien + " " + this.hoTen + " " + this.lop);
        }
        public SinhVien(string maSinhVien, string hoTen, string lop)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.lop = lop;
        }
        #endregion
    }
}
