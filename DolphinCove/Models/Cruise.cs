using System.ComponentModel.DataAnnotations;

namespace DolphinCove.Models
{
    public class Cruise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CruiseName { get; set; }
    }
}