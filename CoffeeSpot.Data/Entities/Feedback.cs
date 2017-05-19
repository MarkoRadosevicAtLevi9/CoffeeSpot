using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSpot.Data.Entities
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public String Comment { get; set; }
        public int Grade { get; set; }
    }
}
