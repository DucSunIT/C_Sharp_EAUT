using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class NhanVienHanhChinh: NhanVien
    {

        // override ghi đè phương thức
        public override double ThuongDuCong(int ngayCong)
        {
            return 0;
        }
    }
}
