using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeSpot.Models
{
    public class FeedbackModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Grade { get; set; }
    }
}