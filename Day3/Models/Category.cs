using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100,MinimumLength =2, ErrorMessage = "Category name cannot exceed 100 characters.")]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; } // navigational property to Product
    }
}
