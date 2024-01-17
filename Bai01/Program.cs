using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien NhanVien = new NhanVien();

            Console.WriteLine("****Nhap thong tin NhanVien:****");
            Console.Write("Nhap ho ten: ");
            NhanVien.HoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            NhanVien.SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay lam them: ");
            NhanVien.SoNgayLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhap xep loai: ");
            NhanVien.XepLoai = Console.ReadLine();
            Console.Write("Nhap bo phan: ");
            NhanVien.BoPhan = Console.ReadLine();

            Console.WriteLine("****Thong tin NhanVien****");
            NhanVien.InThongTin();

            Console.WriteLine("****Thong tin NHANVIEN****");
            NhanVien NHANVIEN = new NhanVien("Nguyen Van A", 5, 2, "A", "GianTiep");
            NHANVIEN.InThongTin();
            Console.ReadLine();
        }
    }
}
