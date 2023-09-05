using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        public int? ParkId { get; set; }
        [ForeignKey("ParkId")]
        public virtual Park? Park { get; set; }

        public string ExperienceName { get; set; }
        public decimal AdultPrice { get; set; }
        public decimal ChildPrice { get; set; }
        public string? ExperienceImage1 { get; set; }
        public string? ExperienceImage2 { get; set; }
        public string? ExperienceImage3 { get; set; }
        public string? ExperienceImage4 { get; set; }
        public int? ExperienceAddonsId { get; set; }
        [ForeignKey("ExperienceAddonsId")]
        public virtual ExperienceAddon? ExperienceAddons { get; set; }
    }
}