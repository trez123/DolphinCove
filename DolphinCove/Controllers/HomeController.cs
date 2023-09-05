using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DolphinCove.Models;
using DolphinCove.Utils;
using DolphinCove.Models.ViewModels;
using DolphinCove.Data;

namespace DolphinCove.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _dbx;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _dbx = db;
    }

    public IActionResult Index()
    {
        List<Park> parks = _dbx.Parks.ToList();
        ViewData["ParksList"] = parks;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

