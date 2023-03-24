using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so lieu
            Console.WriteLine("Moi ban nhap Ngay");
            int Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap Thang");
            int Thang = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Moi ban nhap Nam");
            int Nam = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------KET QUA--------------->");

            DateTime homNay =  new DateTime(Nam,Thang,Ngay).Date;

            Console.WriteLine("Ngay hom qua la: {0}",new DateTime(Nam,Thang,Ngay-1).ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom nay la: {0}", homNay.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay mai la: {0}", new DateTime(Nam, Thang, Ngay + 1).ToString("dd/MM/yyyy"));
            Console.ReadLine();
        }
    }
}
