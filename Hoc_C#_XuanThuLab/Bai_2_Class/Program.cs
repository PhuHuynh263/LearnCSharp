using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_Class
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VuKhi sungLuc = new VuKhi();
            sungLuc.name = "Súng lục";
            sungLuc.ThietLapDoSatThuong(5);
            sungLuc.TanCong();

            VuKhi sungMay = new VuKhi("Súng máy", 30);
            sungMay.TanCong();
            //sungLuc.SatThuong = 10;
            Console.WriteLine(sungLuc.SatThuong);
        }
    }
}
