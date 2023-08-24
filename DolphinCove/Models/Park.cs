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





        //Relationship
        public int? ExperienceId1 { get; set; }
        [ForeignKey("ExperienceId1")]
        public virtual Experience? Experience1 { get; set; }



        public int? ExperienceId2 { get; set; }
        [ForeignKey("ExperienceId2")]
        public virtual Experience? Experience2 { get; set; }



        public int? ExperienceId3 { get; set; }
        [ForeignKey("ExperienceId3")]
        public virtual Experience? Experience3 { get; set; }



        public int? ExperienceId4 { get; set; }
        [ForeignKey("ExperienceId4")]
        public virtual Experience? Experience4 { get; set; }



        public int? ExperienceId5 { get; set; }
        [ForeignKey("ExperienceId5")]
        public virtual Experience? Experience5 { get; set; }



        public int? ExperienceId6 { get; set; }
        [ForeignKey("ExperienceId6")]
        public virtual Experience? Experience6 { get; set; }



        public int? ExperienceId7 { get; set; }
        [ForeignKey("ExperienceId7")]
        public virtual Experience? Experience7 { get; set; }



        public int? ExperienceId8 { get; set; }
        [ForeignKey("ExperienceId8")]
        public virtual Experience? Experience8 { get; set; }



        public ICollection<Experience> Experiences
        {
            get { return new List<Experience> { Experience1, Experience2, Experience3, Experience4, Experience5 }; }
        }
    }
}