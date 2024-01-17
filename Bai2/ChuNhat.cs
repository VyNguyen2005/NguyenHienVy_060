using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class ChuNhat
    {
        public double rong;
        public double dai;

        public ChuNhat()
        {

        }
        public ChuNhat(double rong, double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double Rong
        {
            set { rong = value; }
            get { return rong; }
        }
        public double Dai
        {
            set { dai = value; }
            get { return dai; }
        }
        public double TinhChuVi()
        {
            return (rong + dai) * 2;
        }
        public double TinhDienTich()
        {
            return rong * dai;
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Chieu rong: {Rong}");
            Console.WriteLine($"Chieu dai: {Dai}");
            Console.WriteLine($"Chu Vi: {TinhChuVi()}");
            Console.WriteLine($"Dien Tich: {TinhDienTich()}");
        }
    }
    class Vuong : ChuNhat
    {
        private double canh;
        public Vuong()
        {
            
        }
        public Vuong(double canh) : base(canh, canh)
        {
            
        }
        public double Canh
        {
            set { canh = value; }
            get { return canh; }
        }
        public override void Xuat()
        {
            Console.WriteLine($"Canh: {Rong}");
            Console.WriteLine($"Chu Vi: {TinhChuVi()}");
            Console.WriteLine($"Dien Tich: {TinhDienTich()}");
        }
    }
}
