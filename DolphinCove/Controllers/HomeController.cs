using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DolphinCove.Models;
using Microsoft.EntityFrameworkCore;
using DolphinCove.Data;
using System.IO;

namespace DolphinCove.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SwimAdventure()
    {
        int ExpId = 1;
        string path = AppConst.UploadPathExp;
        Experience? experience = _dbContext.Experiences.FirstOrDefault(e => e.Id == ExpId);
        if (experience == null)
        {
            return NotFound();
        }
        string? experienceImage1 = path + experience.ExperienceImage1;
        string? experienceImage2 = path + experience.ExperienceImage2;
        string? experienceImage3 = path + experience.ExperienceImage3;
        string? experienceImage4 = path + experience.ExperienceImage4;
        ViewData["ExperienceImage1"] = experienceImage1;
        ViewData["ExperienceImage2"] = experienceImage2;
        ViewData["ExperienceImage3"] = experienceImage3;
        ViewData["ExperienceImage4"] = experienceImage4;
        return View(experience);
    }
    public IActionResult SharkEncounter()
    {
        int ExpId = 2;
        string path = AppConst.UploadPathExp;
        Experience? experience = _dbContext.Experiences.FirstOrDefault(e => e.Id == ExpId);
        if (experience == null)
        {
            return NotFound();
        }
        string? experienceImage1 = path + experience.ExperienceImage1;
        string? experienceImage2 = path + experience.ExperienceImage2;
        string? experienceImage3 = path + experience.ExperienceImage3;
        string? experienceImage4 = path + experience.ExperienceImage4;
        ViewData["ExperienceImage1"] = experienceImage1;
        ViewData["ExperienceImage2"] = experienceImage2;
        ViewData["ExperienceImage3"] = experienceImage3;
        ViewData["ExperienceImage4"] = experienceImage4;
        return View(experience);
    }
    public IActionResult Encounter()
    {
        int ExpId = 3;
        string path = AppConst.UploadPathExp;
        Experience? experience = _dbContext.Experiences.FirstOrDefault(e => e.Id == ExpId);
        if (experience == null)
        {
            return NotFound();
        }
        string? experienceImage1 = path + experience.ExperienceImage1;
        string? experienceImage2 = path + experience.ExperienceImage2;
        string? experienceImage3 = path + experience.ExperienceImage3;
        string? experienceImage4 = path + experience.ExperienceImage4;
        ViewData["ExperienceImage1"] = experienceImage1;
        ViewData["ExperienceImage2"] = experienceImage2;
        ViewData["ExperienceImage3"] = experienceImage3;
        ViewData["ExperienceImage4"] = experienceImage4;
        return View();
    }
    public IActionResult AdmissionPlus()
    {
        int ExpId = 4;
        string path = AppConst.UploadPathExp;
        Experience? experience = _dbContext.Experiences.FirstOrDefault(e => e.Id == ExpId);
        if (experience == null)
        {
            return NotFound();
        }
        string? experienceImage1 = path + experience.ExperienceImage1;
        string? experienceImage2 = path + experience.ExperienceImage2;
        string? experienceImage3 = path + experience.ExperienceImage3;
        string? experienceImage4 = path + experience.ExperienceImage4;
        ViewData["ExperienceImage1"] = experienceImage1;
        ViewData["ExperienceImage2"] = experienceImage2;
        ViewData["ExperienceImage3"] = experienceImage3;
        ViewData["ExperienceImage4"] = experienceImage4;
        return View();
    }
    public IActionResult DolphinRoyalSwim()
    {
        int ExpId = 5;
        string path = AppConst.UploadPathExp;
        Experience? experience = _dbContext.Experiences.FirstOrDefault(e => e.Id == ExpId);
        if (experience == null)
        {
            return NotFound();
        }
        string? experienceImage1 = path + experience.ExperienceImage1;
        string? experienceImage2 = path + experience.ExperienceImage2;
        string? experienceImage3 = path + experience.ExperienceImage3;
        string? experienceImage4 = path + experience.ExperienceImage4;
        ViewData["ExperienceImage1"] = experienceImage1;
        ViewData["ExperienceImage2"] = experienceImage2;
        ViewData["ExperienceImage3"] = experienceImage3;
        ViewData["ExperienceImage4"] = experienceImage4;
        return View();
    }
    public IActionResult Privacy()
    {

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

