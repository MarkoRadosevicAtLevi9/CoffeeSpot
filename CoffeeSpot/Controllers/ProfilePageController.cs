using CoffeeSpot.Repositories;
using CoffeeSpot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeSpot.Controllers
{
    public class ProfilePageController : Controller
    {
        ICoffeeSpotRepository coffeeRepository;

        public ProfilePageController(ICoffeeSpotRepository coffeeRepository)
        {
            this.coffeeRepository = coffeeRepository;
        }
        
        // GET: ProfilePage
        public ActionResult Index(int id)
        {
            var coffeeSpotDetails = coffeeRepository.GetCoffeeSpot(id);

            int sumOfGrades = 0;
            foreach (var feedback in coffeeSpotDetails.Feedbacks)
                sumOfGrades += feedback.Grade;

            ViewBag.AverageGrade = sumOfGrades / coffeeSpotDetails.Feedbacks.Count;

            return View(coffeeSpotDetails);
        }
    }
}