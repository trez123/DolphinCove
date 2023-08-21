using DolphinCove.Models;

namespace DolphinCove.Data
{
    public interface IExperienceRepository
    {
        IEnumerable<Park> GetAllParks();
        Park GetParkById(int parkId);
    }
}
