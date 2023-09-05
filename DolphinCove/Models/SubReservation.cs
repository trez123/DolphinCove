using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class SubReservation
    {
        [Key]
        public int Id { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? UndiscountedTotal { get; set; }
        public decimal? FinalTotal { get; set; }
        public DateTime Date { get; set; }

        public int? ParkId { get; set; }
        [ForeignKey("ParkId")]
        public virtual Park? Park{ get; set; }

        public int? ExperienceId { get; set; }
        [ForeignKey("ExperienceId")]
        public virtual Experience? Experience { get; set; }

        public int? ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public virtual Schedule? Schedule { get; set; }

        public int? AddonId { get; set; }
        [ForeignKey("AddonId")]
        public virtual Addon? Addon { get; set; }

        public int? CruiseId { get; set; }
        [ForeignKey("CruiseId")]
        public virtual Cruise? Cruise { get; set; }

        public int? PromoCodeId { get; set; }
        [ForeignKey("PromoCodeId")]
        public virtual PromotionCode? PromotionCode { get; set; }
    }
}
