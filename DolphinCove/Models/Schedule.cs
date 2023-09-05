using System.ComponentModel.DataAnnotations;

namespace DolphinCove.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime AvailableTime { get; set; }
    }
}
