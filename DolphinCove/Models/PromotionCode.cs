using System.ComponentModel.DataAnnotations;

namespace DolphinCove.Models
{
    public class PromotionCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PromoCode { get; set; }

        [Required]
        public decimal PromoPercent { get; set; }
    }
}