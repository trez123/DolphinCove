using DolphinCove.Data;
using DolphinCove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
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

        public class IndexModel
        {
            public int SelectedParkId { get; set; }
            public string ParkName { get; set; }
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

        //[HttpPost]
        //public IActionResult GetExperienceNames(int selectedParkId)
        //{
        //    var selectedPark = _dbx.Parks.Include(p => p.Experience1).
        //        Include(p => p.Experience2).Include(p => p.Experience3).
        //        Include(p => p.Experience4).Include(p => p.Experience5).
        //        FirstOrDefault(p => p.Id == selectedParkId);
        //    if (selectedPark != null)
        //    {
        //        var experienceNames = new List<string>
        //        {
        //            selectedPark.Experience1?.ExperienceName,
        //            selectedPark.Experience2?.ExperienceName,
        //            selectedPark.Experience3?.ExperienceName,
        //            selectedPark.Experience4?.ExperienceName,
        //            selectedPark.Experience5?.ExperienceName
        //        };

        //        var experienceIds = new List<int?>
        //        {
        //            selectedPark.Experience1?.Id,
        //            selectedPark.Experience2?.Id,
        //            selectedPark.Experience3?.Id,
        //            selectedPark.Experience4?.Id,
        //            selectedPark.Experience5?.Id
        //        };

        //        return Json(new { experienceNames, experienceIds });
        //    }

        //    return BadRequest();
        //}


        
        [HttpPost]
        public IActionResult GetExperienceNames(int selectedParkId)
        {
            var selectedPark = _dbx.Parks.Include(p => p.Experience1)
            .Include(p => p.Experience2)
            .Include(p => p.Experience3)
            .Include(p => p.Experience4)
            .Include(p => p.Experience5)
            .FirstOrDefault(p => p.Id == selectedParkId);

            if (selectedPark != null && selectedPark.Experiences.Any())
            {
                var experienceNamesAndIds = new List<object>();
                foreach (var experience in selectedPark.Experiences)
                {
                    if (experience != null) // Check if experience is null
                    {
                        experienceNamesAndIds.Add(new { ExperienceName = experience.ExperienceName, ExperienceId = experience.Id });
                    }
                }
                return Json(experienceNamesAndIds);
            }
            return BadRequest();
        }




        //[HttpPost]
        //public IActionResult SaveId(int id)
        //{
        //    var book = new Reservation { Id = id };
        //    _dbx.Reservations.Add(book);
        //    _dbx.SaveChanges();

        //    return RedirectToAction("Index"); // or any other action you want to redirect to
        //}




        [HttpPost]
        public IActionResult SaveToDb(int selectedParkId, int experienceNames, DateTime schedule_time, DateTime schedule_date,  string adultNumber, string childrenNumber, string infantNumber)
        {

            var reservationExists = _dbx.Reservations.Any(x => x.Date == schedule_time);

            if (!reservationExists)
            {
                // Save the reservation to the database
                var radioSelection = new Reservation
                {   
                    ParkId = selectedParkId,
                    ExperienceId = experienceNames,
                    Date = schedule_time,
                    Schedule = schedule_date,
                    AdultParticipant = adultNumber,
                    ChildParticipant = childrenNumber,
                    InfantParticipant = infantNumber

                    
                };
                _dbx.Reservations.Add(radioSelection);
                _dbx.SaveChanges();
            }

            return RedirectToAction("Index");
        }





    }

}
