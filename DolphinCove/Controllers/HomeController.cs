using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DolphinCove.Models;

namespace DolphinCove.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SwimAdventure()
    {
        return View();
    }
    public IActionResult SharkEncounter()
    {
        return View();
    }
    public IActionResult Encounter()
    {
        return View();
    }
    public IActionResult AdmissionPlus()
    {
        return View();
    }
    public IActionResult DolphinRoyalSwim()
    {
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

