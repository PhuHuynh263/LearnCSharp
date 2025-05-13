using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_VirtualMethod
{
    /*abstract class Product
    {
        public double Price { get; set; }

        public abstract void ProductInfo();



        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 1000;

        public override void ProductInfo()
        {
            Console.WriteLine("Dien thoai Iphone");
            Console.WriteLine("Gia cua san pham : " + Price);
        }

    }*/

    //Interface
    interface IHinhHoc
    {
        double TinhChuVi();
        double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }
        public double TinhChuVi() => (ChieuDai + ChieuRong) * 2;
        public double TinhDienTich() => ChieuDai * ChieuRong;
    }

    class HinhTron : IHinhHoc
    {
        public double BanKinh { get; set; }
        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }
        public double TinhChuVi() => 2 * Math.PI * BanKinh;
        public double TinhDienTich() => Math.PI * BanKinh * BanKinh;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Iphone iphone = new Iphone();
             iphone.Test();*/

            HinhChuNhat hinhChuNhat = new HinhChuNhat(5, 10);
            Console.WriteLine("Chu vi hinh chu nhat: " + hinhChuNhat.TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: " + hinhChuNhat.TinhDienTich());

            HinhTron hinhTron = new HinhTron(5);
            Console.WriteLine("Chu vi hinh tron: " + hinhTron.TinhChuVi());
            Console.WriteLine("Dien tich hinh tron: " + hinhTron.TinhDienTich());

        }
    }
}
