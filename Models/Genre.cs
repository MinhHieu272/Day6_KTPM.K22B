using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
    }
}