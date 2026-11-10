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
            new Product() { Id = 3, Name = "Tablet C", Price = 300, Description = "Tablet C description", CategoryId = 3 },
            new Product() { Id = 4, Name = "Laptop D", Price = 1200, Description = "Laptop D description", CategoryId = 1 },
            new Product() { Id = 5, Name = "Phone E", Price = 600, Description = "Phone E description", CategoryId = 2 },
            new Product() { Id = 6, Name = "Tablet F", Price = 400, Description = "Tablet F description", CategoryId = 3 },
            new Product() { Id = 7, Name = "Laptop G", Price = 1500, Description = "Laptop G description", CategoryId = 1 },
            new Product() { Id = 8, Name = "Phone H", Price = 700, Description = "Phone H description", CategoryId = 2 },
            new Product() { Id = 9, Name = "Tablet I", Price = 500, Description = "Tablet I description", CategoryId = 3 },
            new Product() { Id = 10, Name = "Laptop J", Price = 2000, Description = "Laptop J description", CategoryId = 1 },
            new Product() { Id = 11, Name = "Phone K", Price = 800, Description = "Phone K description", CategoryId = 2 },
            new Product() { Id = 12, Name = "Tablet L", Price = 600, Description = "Tablet L description", CategoryId = 3 },
            new Product() { Id = 13, Name = "Laptop M", Price = 2500, Description = "Laptop M description", CategoryId = 1 },
            new Product() { Id = 14, Name = "Phone N", Price = 900, Description = "Phone N description", CategoryId = 2 },
            new Product() { Id = 15, Name = "Tablet O", Price = 700, Description = "Tablet O description", CategoryId = 3 },
            new Product() { Id = 16, Name = "Laptop P", Price = 3000, Description = "Laptop P description", CategoryId = 1 },
            new Product() { Id = 17, Name = "Phone Q", Price = 1000, Description = "Phone Q description", CategoryId = 2 }

        };
    }
}
