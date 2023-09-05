using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinCove.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public int MasterReservationId { get; set; }
        [ForeignKey("MasterReservationId ")]
        public virtual MasterReservation MasterReservation { get; set; }

        public int? SubReservationId { get; set; }
        [ForeignKey("SubReservationId")]
        public virtual SubReservation? SubReservation { get; set; }

        public int? PromoCodeId { get; set; }
        [ForeignKey("PromoCodeId")]
        public virtual PromotionCode? PromotionCode { get; set; }
    }
}
