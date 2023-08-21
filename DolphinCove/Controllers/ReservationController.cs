using DolphinCove.Data;
using DolphinCove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DolphinCove.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _dbx;

        //Constructor
        public ReservationController(ApplicationDbContext dbx)
        {
            _dbx = dbx;
        }


        


        [HttpGet]
        public IActionResult Index()
        {
            var parks = _dbx.Parks.ToList();

            // Convert the parks to a List object.
            var listParks = parks as List<Park>;

            // If the parks are not a List object, create a new List object.
            if (listParks == null)
            {
                listParks = new List<Park>();
            }

            // Return the parks to the view.
            return View(listParks);

            //return _dbx.Parks;
            //return View();
        }


        [HttpPost]
        public IActionResult Index(int id)
        {
            // Get the radio button by ID.
            var radioButton = _dbx.Parks.FirstOrDefault(r => r.Id == id);

            // Set the selected radio button.
            ViewData["SelectedRadioButton"] = radioButton;

            return View();
        }

        [HttpPost]
        public IActionResult GetExperienceNames(int selectedParkId)
        {
            var selectedPark = _dbx.Parks.Include(p => p.Experience1).
                Include(p => p.Experience2).Include(p => p.Experience3).
                Include(p => p.Experience4).Include(p => p.Experience5).
                FirstOrDefault(p => p.Id == selectedParkId);
            if (selectedPark != null)
            {
                var experienceNames = new List<string>
                {
                    selectedPark.Experience1?.ExperienceName,
                    selectedPark.Experience2?.ExperienceName,
                    selectedPark.Experience3?.ExperienceName,
                    selectedPark.Experience4?.ExperienceName,
                    selectedPark.Experience5?.ExperienceName
                };

                return Json(experienceNames);
            }

            return BadRequest();
        }


    }

}
