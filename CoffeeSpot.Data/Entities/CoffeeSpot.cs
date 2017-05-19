using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSpot.Data.Entities
{
    public class CoffeeSpot
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string WorkingHoursStart { get; set; }
        public string WorkingHoursEnd { get; set; }
        public DateTime? FoundationDate { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
