using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [Range(1, 500)]
        public int Duration { get; set; }
        
        [Required]
        public int GenreId { get; set; }
        
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}