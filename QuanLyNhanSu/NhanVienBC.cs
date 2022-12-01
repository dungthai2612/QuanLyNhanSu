using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class NhanVienBC : NhanVien 
    {
        double hesoluong;
        public double HeSoLuong
        {
            get { return hesoluong; }
            set { hesoluong = value; }

        }
        public NhanVienBC()
        {

        }
        public NhanVienBC(double hesoluong, double heSoLuong)
        {
            this.hesoluong = hesoluong;
            HeSoLuong = heSoLuong;
        }
        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.WriteLine("Nhập hệ số lương :");
            this.HeSoLuong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Xuat();
            Console.WriteLine("Hệ số lương là : {0}" + hesoluong);
            Console.WriteLine("Thâm niên :{0} năm , Phụ cấp {1}" +tinhThamNien() ,+TinhPhuCap());
            Console.WriteLine("Tổng lương là : {0}" + TinhLuongBC());
        }
        public double TinhPhuCap()
        {
            double tienphucap = 0;
            if (tinhThamNien() > 10)
            {
                tienphucap = (10/100 *this.LuongCoBan) + 1500000;
            }
            else if (tinhThamNien() > 5)
            {
                tienphucap = (10/100 *this.LuongCoBan) + 1000000;
            }
            else
                tienphucap = 500000;
            return tienphucap;
        }
        public double TinhLuongBC()
        {
            double TongLuong = 0;
            TongLuong = this.LuongCoBan * this.HeSoLuong + TinhPhuCap();
            return TongLuong;

        }
        
    }
}
