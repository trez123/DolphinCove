using DolphinCove.Data;
using DolphinCove.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;


using static DolphinCove.Controllers.ReservationController;

public class ExperienceRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ExperienceRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Experience> GetAllExperiences()
    {
        return _dbContext.Experiences.ToList();
    }

    public Experience GetExperienceById(int experienceId)
    {
        return _dbContext.Experiences
            .Where(e => e.Id == experienceId)
            .FirstOrDefault();
    }

    public IEnumerable<int> GetExperienceIds(int parkId)
    {
        return _dbContext.Experiences
            .Where(e => e.Id == parkId)
            .Select(e => e.Id);
    }
}