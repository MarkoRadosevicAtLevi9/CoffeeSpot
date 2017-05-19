using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeSpot.Models
{
    public class CoffeeSpotModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Working hours")]
        [RegularExpression("^[0-2]?\\d?[-][0-5]?\\d$", ErrorMessage = "Working hours format is not correct.")]
        public string WorkingHours { get; set; }
        [DisplayName("Foundation date")]
        [Required(ErrorMessage = "This field is required.")]
        public DateTime? FoundationDate { get; set; }
        public List<FeedbackModel> Feedbacks { get; set; }
    }
}