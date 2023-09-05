using DolphinCove.Models;
using Microsoft.EntityFrameworkCore;

namespace DolphinCove.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Addon> Addons { get; set; }
        public DbSet<Cruise> Cruises { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExperienceAddon> ExperienceAddons { get; set; }
        public DbSet<MasterReservation> MasterReservations { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<ParkExperience> ParkExperiences { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PromotionCode> PromotionCodes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        //public DbSet<MasterReservation> Reservations { get; set; }
        public DbSet<SubReservation> SubReservations { get; set; }
        //public DbSet<SelectedParkExperience> SelectedParkExperiences { get; set; }
    }
}
