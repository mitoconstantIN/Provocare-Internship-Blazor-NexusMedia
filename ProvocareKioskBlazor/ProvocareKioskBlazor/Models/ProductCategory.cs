namespace ProvocareKioskBlazor.Models
{
    public class ProductCategory
    {
        public string ProductCategoryName { get; set; }
        public List<Product> Products { get; set; }

        public ProductCategory(string productCategoryName)
        {
            ProductCategoryName = productCategoryName;
            Products = [];
        }

        public void AddProduct(string name, string description, decimal price, int count = 1)
        {
            Products.Add(new Product(name, description, price, count));
        }
    }
}
