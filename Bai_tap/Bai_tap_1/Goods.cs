using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_1
{
    class Goods : Postage
    {
        double weight { set; get; }

        public Goods() { }
        public Goods(string address, string name, double weight) : base(address, name)
        {
            this.weight = weight;
        }
        public override double CalculateShippingCost()
        {
            double cost = weight * 10000;
            return cost;
        }

        public override string ToString()
        {
            return base.ToString() + $"Cost : {CalculateShippingCost()}";
        }
    }
}
