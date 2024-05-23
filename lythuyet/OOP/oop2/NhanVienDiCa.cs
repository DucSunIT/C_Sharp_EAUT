using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class NhanVienDiCa: NhanVien
    {

        private string diCa;

        public string DiCa
        {
            get { return diCa; }    
            set { diCa = value; }
        }

        // định nghĩa lại phương thức -> từ khóa new
        // phương thức cha -> từ khóa base
        public new double TinhLuong()
        {
            return base.TinhLuong()*1.05;
        }
    }
}
