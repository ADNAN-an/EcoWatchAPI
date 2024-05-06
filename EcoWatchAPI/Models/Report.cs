using System;
using System.ComponentModel.DataAnnotations;

namespace EcoWatchAPI.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Type of Incident is required")]
        public TypeOfIncidents TypeOfIncident { get; set; }

        [Required(ErrorMessage = "Gravity is required")]
        public Gravities Gravity { get; set; }

        [Required(ErrorMessage = "Localization is required")]
        public string Localization { get; set; } = "";

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = "";

        public string Image { get; set; } = "";

        // Property to indicate if the report is valid or not
        public bool IsValid { get; set; } = false;

        // Property to store the time of the report
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
