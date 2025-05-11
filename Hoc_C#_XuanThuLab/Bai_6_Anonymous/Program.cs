using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace Bai_6_Anonymous
{

    class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NoiSinh { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                /*var sanPham = new
                {
                    Ten = "Iphone 8",
                    Gia = 10000,
                    NamSx = 2018
                };

                Console.WriteLine(sanPham.Ten);
                Console.WriteLine(sanPham.Gia);
                Console.WriteLine(sanPham.NamSx);*/


                List<SinhVien> cacSinhVien = new List<SinhVien>() {
                new SinhVien()
                {
                    HoTen = "Phu",
                    NamSinh = 2000,
                    NoiSinh = "Da Nang"
                },

                new SinhVien()
                {
                    HoTen = "Phu",
                    NamSinh = 2000,
                    NoiSinh = "Da Nang"
                },

                new SinhVien()
                {
                    HoTen = "Phu",
                    NamSinh = 2000,
                    NoiSinh = "Da Nang"
                },

                new SinhVien()
                {
                    HoTen = "Phu",
                    NamSinh = 2000,
                    NoiSinh = "Da Nang"
                }};

                var kq = from sv in cacSinhVien
                         where sv.NamSinh <= 2001
                         select new
                         {
                             Ten = sv.HoTen,
                             NS = sv.NoiSinh,
                         };
                foreach (var item in kq)
                {
                    Console.WriteLine(item.Ten + " - " + item.NS);
                }
            }
        }
    }
}
