using System;
using System.Linq;
using System.Web.Http;
using CoffeeSpot.Models;
using CoffeeSpot.Repositories.Interfaces;

namespace CoffeeSpot.Controllers.Api
{
    [RoutePrefix("api/coffee-spots")]
    public class CoffeeSpotsController : ApiController
    {
        private readonly ICoffeeSpotRepository _coffeeRepository;

        public CoffeeSpotsController(ICoffeeSpotRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        [Route(""), HttpGet]
        public IHttpActionResult GetAllCoffeeSpots()
        {
            var coffeeSpots = _coffeeRepository.GetAllCofeeSpots();

            var responseData = coffeeSpots.Select(coffeeSpot => new CoffeeSpotModel
            {
                Id = coffeeSpot.Id,
                Name = coffeeSpot.Name,
                Address = coffeeSpot.Address,
                Description = coffeeSpot.Description,
                Feedbacks = coffeeSpot.Feedbacks.Select(feedback => new FeedbackModel
                {
                    Id = feedback.Id,
                    Grade = feedback.Grade,
                    Comment = feedback.Comment
                }).ToList(),
                FoundationDate = coffeeSpot.FoundationDate,
                WorkingHours = coffeeSpot.WorkingHours,
            }).ToList();

            return Ok(responseData);
        }

        [Route("{id:int}"), HttpGet]
        public IHttpActionResult GetCoffeeSpotById(int id)
        {
            var coffeeSpot = _coffeeRepository.GetCoffeeSpot(id);

            if (coffeeSpot == null)
            {
                return NotFound();
            }

            var responseData = new CoffeeSpotModel
            {
                Id = coffeeSpot.Id,
                Name = coffeeSpot.Name,
                Address = coffeeSpot.Address,
                Description = coffeeSpot.Description,
                Feedbacks = coffeeSpot.Feedbacks.Select(feedback => new FeedbackModel
                {
                    Id = feedback.Id,
                    Grade = feedback.Grade,
                    Comment = feedback.Comment
                }).ToList(),
                FoundationDate = coffeeSpot.FoundationDate,
                WorkingHours = coffeeSpot.WorkingHours,
            };

            return Ok(responseData);
        }

        [Route(""), HttpPost]
        public IHttpActionResult InsertCoffeeSpot([FromBody] CoffeeSpotModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _coffeeRepository.SaveCoffeeSpot(model);

            return Ok();
        }

        [Route(""), HttpDelete]
        public IHttpActionResult DeleteCoffeeSpot()
        {
            throw new NotImplementedException();
        }
    }
}
