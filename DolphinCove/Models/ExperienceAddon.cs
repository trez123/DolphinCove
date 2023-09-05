using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class ExperienceAddon
    {
        [Key]
        public int Id { get; set; }
        
        public int? ExperienceId { get; set; }
        [ForeignKey("ExperienceId")]
        public virtual Experience? Experience { get; set; }

        public int? AddonId { get; set; }
        [ForeignKey("AddonId")]
        public virtual Addon? Addon { get; set; }
    }
}
