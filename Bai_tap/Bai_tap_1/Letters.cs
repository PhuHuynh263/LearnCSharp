using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_1
{
    class Letters : Postage
    {
        bool isFast { set; get; }

        public Letters() { }
        public Letters(string address, string name, bool isFast) : base(address, name)
        {
            this.isFast = isFast;
        }

        public override double CalculateShippingCost()
        {
            double cost = isFast ? 3000 : 500;
            return cost;
        }
    }
}
