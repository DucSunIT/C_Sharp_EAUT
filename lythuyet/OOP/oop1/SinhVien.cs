using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class SinhVien
    {
        #region khai báo biến 
        // khai báo biến 
        private int maSinhVien;
        private string hoTen;
        private double diemThiDaiHoc;
        #endregion

        #region constructor
        //khởi tạo constructor rỗng gán giá trị mặc định
        public SinhVien()
        {
            this.maSinhVien = 0;
            this.hoTen = "No name";
            this.diemThiDaiHoc = 0;
        }
        //khởi tạo constructor giá trị do người dùng gán
        public SinhVien(int maSinhVien, string hoTen, double diemThiDaiHoc)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.diemThiDaiHoc = diemThiDaiHoc;
        }
        #endregion

        #region properties
        // properties
        public int MaSinhVien
        {
            get { return this.maSinhVien; } // lấy ra giá trịi 
            set { this.maSinhVien = value; } // gán giá trị 
        }

        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        public double DiemThiDaiHoc
        {
            get { return this.diemThiDaiHoc; }
            set { this.diemThiDaiHoc = value; }
        }
        #endregion

        #region method
        // hiển thị đoạn văn bản
        public override string ToString()
        {
            return this.hoTen + "\t" + this.maSinhVien;
        }

        // overloading

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Sum(double x, double y, double z)
        {
            return x + y + z;
        }

        // prams -> truyền bao nhiêu đối số cũng được

        public double TBC(params double[] arr)
        {
            double sum = 0;
            foreach(double x in arr)
            {
                sum += x;
            }
            return (sum/arr.Count());
        }
        
        // support method and service method
        // kiểm tra xem điểm thi đại học của sinh viên có lớn hơn 21 không
        // support method -> private
        private bool checkDiemThi()
        {
            return (this.diemThiDaiHoc - 21 >= 0);
        }

        // secrvice method -> public
        public void thongTin()
        {
            if (!checkDiemThi())
            {
                Console.WriteLine("Điểm thi của sinh viên <21, vui lòng kiểm tra lại !");
            }
            else
            {
                Console.WriteLine(this.ToString());
            }
        }
        #endregion

    }
}
