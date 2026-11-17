using System.ComponentModel.DataAnnotations;

namespace Day6_pj2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength =5, ErrorMessage = "Title cannot be longer than 200 characters.")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseYear { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
