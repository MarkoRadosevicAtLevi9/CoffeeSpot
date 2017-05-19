using CoffeeSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSpot.Repositories.Interfaces
{
    public interface ICoffeeSpotRepository
    {
        List<CoffeeSpotModel> GetAllCofeeSpots();

        CoffeeSpotModel GetCoffeeSpot(int id);

        //void SaveFeedbackForCoffeeSpot(int cofeeSpotID);

        void SaveCoffeeSpot(CoffeeSpotModel cofeeSpotModel);

    }
}
