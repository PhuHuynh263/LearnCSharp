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
        public override string ToString()
        {
            return base.ToString() + $"Cost : {CalculateShippingCost()}";
        }
    }
}
