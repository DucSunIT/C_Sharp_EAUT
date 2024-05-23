using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class HocSinh
    {
        public int maSinhVien { get; set; }
        public string hoTen { get; set; }
        public string lop {  get; set; }

        // toString
        public override string ToString()
        {
            return this.maSinhVien + "\t" + this.hoTen + "\t" + this.lop;
        }
    }
}
