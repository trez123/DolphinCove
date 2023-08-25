using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class ParkExperience
    {
        public int Id { get; set; }





        //Relationship
        public int? ParkId { get; set; }
        [ForeignKey("ParkId")]
        public virtual Park? Park { get; set; }


        public int? ExperienceId { get; set; }
        [ForeignKey("ExperienceId")]
        public virtual Experience? Experience { get; set; }
    }
}
