using System.ComponentModel.DataAnnotations;

namespace DolphinCove.Models
{
    public class Addon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AddonName { get; set; }

        [Required]
        public decimal AddonPrice { get; set; }

        public string AddonImage1 { get; set; }
    }
}