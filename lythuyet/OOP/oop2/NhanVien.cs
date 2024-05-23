using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class NhanVien
    {
        private int maNhanVien;
        private string tenNhanVien;

        public int MaNhanVien
        {
            get
            {
                return this.maNhanVien;
            }
            set
            {
                this.maNhanVien = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return this.tenNhanVien;
            }

            set
            {
                this.tenNhanVien = value;
            }
        }

        public double TinhLuong()
        {
            return 1000; // lương cơ bản 1000$
        }

        // vitrual -> hàm ảo
        public virtual double ThuongDuCong(int ngayCong)
        {
            if (ngayCong >= 26) return 100;
            else return 0;
        }
    }
}
