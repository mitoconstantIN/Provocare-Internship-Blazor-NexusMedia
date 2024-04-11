namespace ProvocareKioskBlazor.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Product(string name, string description, decimal price, int count = 0)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }
    }
}
