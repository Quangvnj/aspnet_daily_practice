using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // navigational property to Category
        public Category? Category { get; set; } // navigational property to Category
    }
}
