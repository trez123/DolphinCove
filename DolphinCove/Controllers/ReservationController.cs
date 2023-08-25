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
            // Create a query to get the experience names and experience IDs from the Experience table based on the selected park ID.
            var query = from experience in _dbx.Experiences
                        join parkExperience in _dbx.ParkExperiences on experience.Id equals parkExperience.ExperienceId
                        where parkExperience.ParkId == selectedParkId
                        select new { ExperienceId = experience.Id, ExperienceName = experience.ExperienceName };

            // Execute the query and get the results.
            var experienceNamesAndIds = query.ToList();

            // Return the experience names and experience IDs to the view.
            return Json(experienceNamesAndIds);
        }






        [HttpPost]
        public IActionResult SaveToDb(int selectedParkId, int experience, DateTime schedule_time, DateTime schedule_date, string adultNumber, string childrenNumber, string infantNumber)
        {

            var reservationExists = _dbx.Reservations.Any(x => x.Date == schedule_time);

            if (!reservationExists)
            {

                var selectedParkExperience = new SelectedParkExperience
                {
                    SelectedParkId = selectedParkId,
                    SelectedExperienceId = experience
                };

                _dbx.SelectedParkExperiences.Add(selectedParkExperience);
                _dbx.SaveChanges();

                // Get the ID of the selected park experience.
                var selParkExperience = _dbx.SelectedParkExperiences.FirstOrDefault(x => x.SelectedParkId == selectedParkId && x.SelectedExperienceId == experience);

                var selectedParkExperienceId = selectedParkExperience.Id;


                // Save the reservation to the database
                var radioSelection = new Reservation
                {
                    SelectedParkExperienceId = selectedParkExperienceId,
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
