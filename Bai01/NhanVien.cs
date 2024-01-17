using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string hoTen;
        private int soNgaycong;
        private int soNgaylamthem;
        private string xepLoai;
        private string boPhan;

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, int soNgaycong, int soNgaylamthem, string xepLoai, string boPhan)
        {
            this.hoTen = hoTen;
            this.soNgaycong = soNgaycong;
            this.soNgaylamthem = soNgaylamthem;
            this.xepLoai = xepLoai;
            this.boPhan = boPhan;
        }
        public string HoTen
        {
            set { hoTen = value; }
            get { return hoTen; }
        }
        public int SoNgayCong
        {
            set { soNgaycong = value; }
            get { return soNgaycong; }
        }
        public int SoNgayLamThem
        {
            set { soNgaylamthem = value; }
            get { return soNgaylamthem; }
        }
        public string XepLoai
        {
            set { xepLoai = value; }
            get { return xepLoai; }
        }
        public string BoPhan
        {
            set { boPhan = value; }
            get { return boPhan; }
        }
        public double TinhLuong()
        {
            double luongmotngay = 100000;
            double phantramtang;
            if (BoPhan == "TrucTiep")
            {
                phantramtang = 3.0;
            }
            else if (BoPhan == "GianTiep")
            {
                phantramtang = 2.0;
            }
            else
            {
                phantramtang = 0.0;
            }
            double luong = (SoNgayCong + SoNgayLamThem * phantramtang) * luongmotngay;
            return luong;
        }
        public double TinhThuNhap()
        {
            double phantram;
            if(XepLoai == "A")
            {
                phantram = 1.5;
            }
            else if(XepLoai == "B")
            {
                phantram = 1.2;
            }
            else if(XepLoai == "C")
            {
                phantram = 1.0;
            }
            else
            {
                phantram = 0.0;
            }
            double thunhap = phantram * TinhLuong();
            return thunhap;
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Bo phan: {BoPhan}");
            Console.WriteLine($"Thu nhap: {TinhThuNhap()}");
        }
    }
}
