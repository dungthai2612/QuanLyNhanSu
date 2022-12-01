using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class NhanVienHD : NhanVien
    {
        double ngaycong;
        public double NgayCong
        {
            get { return ngaycong; }
            set { ngaycong = value; }

        }
        public NhanVienHD()
        {

        }
        public NhanVienHD(double ngaycong)
        {
            this.NgayCong = ngaycong;
            
        }
        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.WriteLine("Nhập hệ số lương :");
            this.NgayCong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Hệ số lương là : {0}" + ngaycong);
            Console.WriteLine("Tổng lương là : {0}" + TinhLuong());
        }
        public double TinhPhuCap()
        {
            double tienphucap = 0;
            if (tinhThamNien() > 2)
            {
                tienphucap = (5/ 100 * this.ngaycong) + 700000;
            }
            else if (tinhThamNien() < 2)
            {
                tienphucap = (5/ 100 * this.ngaycong) + 500000;
            }
           
            return tienphucap;
        }
        public double TinhLuong()
        {
            double TongLuong = 0;
            TongLuong = this.NgayCong *(this.LuongCoBan / this.NgayCong) + TinhPhuCap();
            return TongLuong;

        }
    }
}
