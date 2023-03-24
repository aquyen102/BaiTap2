using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so lieu
            Console.WriteLine("Moi ban nhap so nguyen a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so nguyen b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------KET QUA--------------->");

            //Tinh toan va xuat du lieu
            Console.WriteLine("Tong cua a & b la {0}", a + b);
            Console.WriteLine("Hieu cua a & b la {0}", a - b);
            Console.WriteLine("Tich cua a & b la {0}", a * b);
            Console.WriteLine("Thuong cua a & b la {0}", a*(1.0f) / b);
            Console.ReadKey();
        }
    }
}
