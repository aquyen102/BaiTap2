using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so lieu
            Console.WriteLine("Moi ban nhap Ho va Ten");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Moi ban nhap Lop");
            string Lop = Console.ReadLine();
            Console.WriteLine("Moi ban nhap Diem trung binh HKI");
            double diemtrungbinh_HK1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap Diem trung binh HKII");
            double diemtrungbinh_HK2 = double.Parse(Console.ReadLine());
            Console.WriteLine("<-------------KET QUA--------------->");

            //Tinh toan va xuat du lieu
            Console.WriteLine("Diem trung binh ca nam la {0}", (diemtrungbinh_HK1 +2*diemtrungbinh_HK2)/3);
            Console.ReadKey();
        }
    }
}
