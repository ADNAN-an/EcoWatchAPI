using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoWatchAPI.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public string Content { get; set; } = "";

        public string ImagePath { get; set; } = "";
        public DateTime CreatedAt { get; set; }

    }
}
