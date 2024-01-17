using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double rong = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh: ");
            double canh = double.Parse(Console.ReadLine());

            Console.WriteLine("****Thong tin Chu Nhat****");
            ChuNhat chunhat = new ChuNhat(rong, dai);
            chunhat.Xuat();
            Console.WriteLine("****Thong tin Vuong****");
            ChuNhat vuong = new Vuong(canh);
            vuong.Xuat();

            Console.ReadLine();

        }
    }
}
