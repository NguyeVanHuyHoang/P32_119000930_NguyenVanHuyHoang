using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Comment
    {
        public int ID { get; set; }
         [Required]
        public string Content { get; set; } = string.Empty;
         [Required]
        public string Author { get; set; } = string.Empty;
         [Required]
        public string CreatedAt { get; set; } = string.Empty;
    }
}