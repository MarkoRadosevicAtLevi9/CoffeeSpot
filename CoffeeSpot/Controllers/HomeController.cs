using CoffeeSpot.Models;
using CoffeeSpot.Repositories;
using CoffeeSpot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeSpot.Controllers
{
    public class HomeController : Controller
    {
        ICoffeeSpotRepository coffeeRepository;

        public HomeController(ICoffeeSpotRepository coffeeRepository)
        {
            this.coffeeRepository = coffeeRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var coffeeSpots = coffeeRepository.GetAllCofeeSpots();

            return View(coffeeSpots);
        }

        public ActionResult CreateCoffeeSpot(CoffeeSpotModel model)
        {
            coffeeRepository.SaveCoffeeSpot(model);
            return RedirectToAction("Index");
        }

        public ActionResult ClearForm()
        {
            return PartialView("_AddCoffeeSpot", new CoffeeSpotModel());
        }

    }
}