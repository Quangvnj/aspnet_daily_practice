using Day3.Models;

namespace Day3.Data
{
    public class DataSeeds
    {
        // Giả lập dữ liệu cho Category
        public static List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Laptop" },
            new Category() { Id = 2, Name = "Phone" },
            new Category() { Id = 3, Name = "Tablet" }
        };
        // Giả lập dữ liệu cho Product
        public static List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Laptop A", Price = 1000, Description = "Laptop A description", CategoryId = 1 },
            new Product() { Id = 2, Name = "Phone B", Price = 500, Description = "Phone B description", CategoryId = 2 },
            new Product() { Id = 3, Name = "Tablet C", Price = 300, Description = "Tablet C description", CategoryId = 3 }
        };
    }
}
