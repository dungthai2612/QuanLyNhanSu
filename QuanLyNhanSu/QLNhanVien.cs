using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class QLNhanVien
    {
        Dictionary<string, NhanVien> danhsachnhanvien = new Dictionary<string, NhanVien>();
        internal Dictionary<string, NhanVien> DanhSachNhanVien
        {
            get { return danhsachnhanvien; }
            set { danhsachnhanvien = value; }
        }
        public QLNhanVien()
        {}
        public void LuaChon()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("*-------------------------------------------------------------*");
                Console.WriteLine("|                CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN               |");
                Console.WriteLine("*-------------------------------------------------------------*");
                Console.WriteLine("| - Nhập 0 để kết thúc chương trình                           |");
                Console.WriteLine("| - Nhập 1 để nhập thông tin nhân viên                        |");
                Console.WriteLine("| - Nhập 2 để in thông tin nhân viên                          |");
                Console.WriteLine("| - Nhập 3 để tìm nhân viên theo mã nhân viên                 |");
                Console.WriteLine("*-------------------------------------------------------------*");
                string luaChon = Console.ReadLine();
                if (luaChon == "0")
                    break;
                else if (luaChon == "1")
                    Nhap();
                else if(luaChon == "2")
                    Xuat();


            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Nhập A để nhập nhân viên biên chế \nNhập B để nhập nhân viên hợp đồng \nNhập E để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "E") break;
                if (option == "A")
                {
                    NhanVien BC = new NhanVienBC();
                    while (true)
                    {
                        try {
                            BC.Nhap();
                            danhsachnhanvien.Add(BC.MANV, BC);
                            break;

                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
                else if (option == "B")
                {
                    NhanVien HD = new NhanVienHD();
                    while (true)
                    {
                        try
                        {
                            HD.Nhap();
                            danhsachnhanvien.Add(HD.MANV, HD);
                            break;

                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
                else Console.WriteLine("Nhập sai lựa chọn");
            }
        }
        public void Xuat()
        {
            foreach(NhanVien item in danhsachnhanvien.Values)
            {
                item.Xuat();
            }
        }

    }
}
