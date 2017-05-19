using CoffeeSpot.Data.Entities;
using System.Data.Entity;

namespace CoffeeSpot.Data
{
    public interface ICoffeeSpotContext
    {
        DbSet<CoffeeSpot.Data.Entities.CoffeeSpot> CoffeeSpots { get; set; }
        DbSet<Feedback> Feedbacks { get; set; }

        int SaveChanges();
    }
}
