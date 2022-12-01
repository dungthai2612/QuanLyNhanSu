using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            QLNhanVien QLNS = new QLNhanVien();
            QLNS.LuaChon();
            Console.WriteLine("Chương trình kết thúc");
            Console.WriteLine();
        }
    }
}
