using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class NhanVien
    {
        string manv;
        public string MANV
        {
            get { return manv; }
            set { manv = value; }
        }
        string hoten;
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        DateTime ngayvaocoquan;
        public DateTime NgayVaoCoQuan
        {
            get { return ngayvaocoquan; }
            set { ngayvaocoquan = value; }
        }
        double luongcoban;
        public double LuongCoBan
        {
            get { return luongcoban; }
            set
            {
                luongcoban = value;
            }
        }
        public NhanVien()
        {

        }
        public NhanVien(string manv, string hoten, DateTime ngayvaocoquan, double luongcoban)
        {
            this.manv = manv;
            
            this.hoten = hoten;
            
            this.ngayvaocoquan = ngayvaocoquan;
            
            this.luongcoban = luongcoban;
            
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã số nhân viên : ");  this.manv=Console.ReadLine() ;
            Console.WriteLine("Nhập họ tên nhân viên : "); this.hoten = Console.ReadLine();
            Console.WriteLine("Nhập ngày vào cơ quan : "); this.ngayvaocoquan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lương cơ bản : "); this.luongcoban = double.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine("Mã số nhân viên là :{0} ",this.manv);
            Console.WriteLine("Họ tên nhân viên là : {0}", this.hoten);
            Console.WriteLine("Ngày vào cơ quan là : {0}", this.ngayvaocoquan.ToString("dd/MM/yyyy"));
            Console.WriteLine("Lương cơ bản là : {0}", this.LuongCoBan);
        }
        public int tinhThamNien()
        {
            DateTime now = DateTime.Now;
            int SoNam = 0;
            SoNam = (now.Year - this.ngayvaocoquan.Year);
            if (now < this.ngayvaocoquan.AddYears(SoNam))
                SoNam--;
            return SoNam;
            
        }
    }
}
