using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_5
{
    class Program
    {
        //Khai bao thong tin
        class Thong_Tin_Nhan_Vien
        {
            public string hoTen { get; set; }
            public string gioiTinh { get; set; }
            public DateTime ngaySinh { get; set; }
            public Double hesoLuong { get; set; }
            public Double luongCoban { get; set; }
            public double soNamlamviec { get; set; }
            public double phuCapnhanvien { get; set; }

            public Thong_Tin_Nhan_Vien(string hoten, string gt, DateTime BoD, double HSluong, double luongCB, double soNamlamviec)
            {
                this.hoTen = hoten;
                this.gioiTinh = gt;
                this.ngaySinh = BoD;
                this.hesoLuong = HSluong;
                this.luongCoban = luongCB;
                this.soNamlamviec = soNamlamviec;
                if (soNamlamviec > 5)
                {
                    this.phuCapnhanvien = this.luongCoban * 0.5;
                }
                else { this.phuCapnhanvien = 0; }
            }
        }

        static void Main(string[] args)
        {
            Thong_Tin_Nhan_Vien nv1 = new Thong_Tin_Nhan_Vien("Nguyen Van A", "Nam", new DateTime(1993,04,27).Date, 0.5, 1500000, 2);
            Thong_Tin_Nhan_Vien nv2 = new Thong_Tin_Nhan_Vien("Tran Thi B", "Nu", new DateTime(1996, 02, 26).Date, 0.5, 500000, 6.5);
            Console.WriteLine("Nhan vien 1: \n {0}\n {1} \n {2}  \n {3}  \n {4} \n {5}  \n {6} ", nv1.hoTen,nv1.gioiTinh,nv1.ngaySinh,nv1.hesoLuong,nv1.luongCoban,nv1.soNamlamviec,nv1.phuCapnhanvien);
            Console.WriteLine("Nhan vien 2: \n {0}\n {1} \n {2}  \n {3}  \n {4} \n {5}  \n {6} ", nv2.hoTen, nv2.gioiTinh, nv2.ngaySinh,nv2.hesoLuong, nv2.luongCoban, nv2.soNamlamviec, nv2.phuCapnhanvien);
            Console.ReadKey();
        }
    }
}
