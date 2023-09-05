namespace DolphinCove.Models.ViewModels
{
    public class ParkExperienceVM
    {
        public ParkExperienceVM()
        {
            ParkExperience = new ParkExperience();
        }
        public ParkExperience ParkExperience { get; set;}
        public bool ExistsInCart { get; set;}
    }
}
