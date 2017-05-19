using CoffeeSpot.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSpot.Data
{
    public class CoffeeSpotContext : DbContext, ICoffeeSpotContext
    {
        public CoffeeSpotContext() : base("CoffeeSpotConnectionString")
        {
        }

        public DbSet<CoffeeSpot.Data.Entities.CoffeeSpot> CoffeeSpots { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
