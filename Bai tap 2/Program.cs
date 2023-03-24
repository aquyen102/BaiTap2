using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so lieu
            Console.WriteLine("Moi ban nhap chieu dai canh a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu dai canh b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------KET QUA--------------->");

            //Tinh toan va xuat du lieu
            Console.WriteLine("Dien tich cua Hinh Chu Nhat a & b la {0}", a * b);
            Console.WriteLine("Chu vi cua Hinh Chu Nhat a & b la {0}", 2*(a+b));
            Console.ReadKey();
        }
    }
}
