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

        [StringLength(1024)]
        public string Content { get; set; } = "";

        public string ImagePath { get; set; } = "";

        [Display(Name = "Report Time")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

    }
}
