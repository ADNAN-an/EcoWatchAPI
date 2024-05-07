using System;
using System.ComponentModel.DataAnnotations;

namespace EcoWatchAPI.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public string UserId { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Type of Incident is required")]
        public TypeOfIncidents TypeOfIncident { get; set; }

        [Required(ErrorMessage = "Gravity is required")]
        public Gravities Gravity { get; set; }

        [Required(ErrorMessage = "Localization is required")]
        public string Localization { get; set; } = "";

        [StringLength(1024)]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = "";


        [Display(Name = "Image ")]
        public string Image { get; set; } = "";

        
        public bool IsValid { get; set; } = false;

        [Display(Name = "Report Time")]
        [DataType(DataType.DateTime)]
        public DateTime ReportTime { get; set; } = DateTime.Now;

        public enum TypeOfIncidents
        {
            Option1,
            Option2,
            Option3
        }

        public enum Gravities
        {
            High,
            Medium,
            Low
        }
    }
}
