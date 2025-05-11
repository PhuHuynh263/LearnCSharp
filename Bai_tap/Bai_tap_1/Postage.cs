namespace Bai_tap_1
{
    abstract class Postage
    {
        public string address { set; get; }
        public string name { set; get; }

        public Postage() { }
        public Postage(string address, string name)
        {
            this.address = address;
            this.name = name;

        }

        public abstract double CalculateShippingCost();

        public override string ToString()
        {
            return $"Name : {this.name}\nAddress : {this.address}\n";
        }
    }
}
