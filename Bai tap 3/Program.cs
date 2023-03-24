using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so lieu
            Console.WriteLine("Moi ban nhap duong kinh a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------KET QUA--------------->");

            //Tinh toan va xuat du lieu
            Console.WriteLine("Ban kinh hinh tron la {0}", (1.0f)*a/2);
            Console.WriteLine("Chu vi hinh tron la {0}",Math.Round(Math.PI,4)*a);
            Console.WriteLine("Dien tich hinh tron la {0}",Math.Round(Math.PI, 4) * a*a);
            Console.ReadKey();
        }
    }
}
