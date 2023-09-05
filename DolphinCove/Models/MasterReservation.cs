using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class MasterReservation
    {
        [Key]
        public int Id { get; set; }
        public string? GuestFirstName { get; set; }
        public string? GuestLastName { get; set; }
        public string? City { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? AdultParticipant { get; set; }
        public string? ChildParticipant { get; set; }
        public string? InfantParticipant { get; set; }
        public string? SpecialInstructions { get; set; }
        //public decimal? SubTotal { get; set; }
        //public decimal? UndiscountedTotal { get; set;}
        //public decimal? FinalTotal { get; set;}
        public bool? BoolCruise { get; set;}

        public int? SubReservationId { get; set; }
        [ForeignKey("SubReservationId")]
        public virtual SubReservation? SubReservation { get; set; }

        //public int? SelectedParkExperienceId { get; set; }
        //[ForeignKey("SelectedParkExperienceId")]
        //public virtual SelectedParkExperience? SelectedParkExperience { get; set; }

    }
}
