using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Schedule { get; set; }

        public string? AdultParticipant { get; set; }

        public string? ChildParticipant { get; set; }

        public string? InfantParticipant { get; set; }

        public decimal? UndiscountedTotal { get; set;}

        public decimal? FinalTotal { get; set;}

        public string? SpecialInstruction { get; set;}

        public bool? BoolCruise { get; set;}

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? City { get; set; }

        public string? PhoneNumber { get; set; }

        public string? EmailAddress { get; set; }




        //Relationship
        public int? ExperienceId { get; set; }
        [ForeignKey("ExperienceId")]
        public virtual Experience? Experience { get; set; }



        public int? PromotionCodeId { get; set; }
        [ForeignKey("PromotionCodeId")]
        public virtual PromotionCode? PromotionCode { get; set; }



        public int? AddonId { get; set; }
        [ForeignKey("AddonId")]
        public virtual Addon? Addon { get; set; }



        public int? CruiseId { get; set; }
        [ForeignKey("CruiseId")]
        public virtual Cruise? Cruise { get; set; }



        public int? ParkId { get; set; }
        [ForeignKey("ParkId")]
        public virtual Park? Park { get; set; }

    }
}
