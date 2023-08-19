using System.ComponentModel.DataAnnotations;

namespace DolphinCove.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ExperienceName { get; set; }

        [Required]
        public decimal ExperiencePrice { get; set; }

        //[Required]    // wont save if required idk why 0_0
        public string? ExperienceImage1 { get; set; }

        public string? ExperienceImage2 { get; set; }

        public string? ExperienceImage3 { get; set; }

        public string? ExperienceImage4 { get; set; }
    }
}

