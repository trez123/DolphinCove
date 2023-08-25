using DolphinCove.Models;
using Microsoft.EntityFrameworkCore;

namespace DolphinCove.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Addon> Addons { get; set; }

        public DbSet<Cruise> Cruises { get; set; }

        public DbSet<PromotionCode> PromotionCodes { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Park> Parks { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ParkExperience> ParkExperiences { get; set; }

        public DbSet<SelectedParkExperience> SelectedParkExperiences { get; set; }
    }
}
