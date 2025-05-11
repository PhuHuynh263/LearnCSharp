namespace SanPham
{
    public partial class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public string GetInfo()
        {
            return $"{Name} / {Price} / {description}";
        }
    }
}