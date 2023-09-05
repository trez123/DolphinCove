using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class Park
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ParkName { get; set; }

        public string? DropdownImage { get; set; }
    }
}