using System.Collections.Generic;

namespace ProvocareKioskBlazor.Models
{
    public class Catalog
    {
        public List<ProductCategory> ProductCategories { get; set; }

        public Catalog()
        {
            ProductCategories = new List<ProductCategory>();

            // Adaugă categoriile și produsele în catalog
            ProductCategory fruitsCategory = new ProductCategory("Fruits");
            fruitsCategory.AddProduct("Apple", "Sweet and crunchy", 1.99M);
            fruitsCategory.AddProduct("Banana", "Rich in potassium", 0.79M);
            fruitsCategory.AddProduct("Orange", "Citrusy and refreshing", 2.49M);

            ProductCategory vegetablesCategory = new ProductCategory("Vegetables");
            vegetablesCategory.AddProduct("Carrot", "High in vitamin A", 1.29M);
            vegetablesCategory.AddProduct("Broccoli", "Nutrient-rich green vegetable", 2.99M);
            vegetablesCategory.AddProduct("Tomato", "Versatile and juicy", 1.49M);

            ProductCategory dairyCategory = new ProductCategory("Dairy");
            dairyCategory.AddProduct("Milk", "Essential for calcium", 3.49M);
            dairyCategory.AddProduct("Cheese", "Various flavors and types", 4.99M);
            dairyCategory.AddProduct("Yogurt", "Probiotic goodness", 2.79M);

            ProductCategories.Add(fruitsCategory);
            ProductCategories.Add(vegetablesCategory);
            ProductCategories.Add(dairyCategory);
        }
    }
}
