using CoffeeSpot.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSpot.Data
{
    public class CoffeeSpotInitializer : System.Data.Entity.DropCreateDatabaseAlways<CoffeeSpotContext>
    {
        protected override void Seed(CoffeeSpotContext context)
        {
            var feedbacks = new List<Feedback>
            {
                new Feedback{ Comment="This is one very cool coffee place.", Grade = 5, Id=1},
                new Feedback{ Comment="This is not so cool caffee.", Grade = 3, Id=2}
            };

            var coffeeSpots = new List<Entities.CoffeeSpot>
            {
                new Entities.CoffeeSpot{ Address="Address 1", Id=1, Name="CofeeShop", Description="A coffeehouse, coffee shop, or café (sometimes spelled cafe) is an establishment which primarily serves hot coffee, related coffee beverages (e.g., café latte, cappuccino, espresso), tea, and other hot beverages. ... Many cafés also serve some type of food, such as light snacks, muffins, or pastries.", WorkingHoursStart="08:00", WorkingHoursEnd="00:00", Feedbacks=new List<Feedback>() { feedbacks.First() } },
                new Entities.CoffeeSpot{ Address="Address 2", Id=2, Name="Irish Pub", Description="Otvoren je 10. jula 1997 god. u jednoj od najstarijih kuća u Novom Sadu, na uglu Zmaj Jovine i Dunavske ulice.", WorkingHoursStart="09:00", WorkingHoursEnd="01:00", Feedbacks=new List<Feedback>() { feedbacks.Last() } }
            };

            coffeeSpots.ForEach(s => context.CoffeeSpots.Add(s));
            context.SaveChanges();
        }
    }
}
