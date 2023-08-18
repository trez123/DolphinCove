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
    }
}