using FoodAPI.Interfaces;
using FoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.Services
{
    public class FoodItemService : IFoodItem
    {
        private readonly FoodDBContext _context;
        public FoodItemService(FoodDBContext context)
        {
            this._context = context;
        }
        public void CreateFoodItem(FoodItem foodItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteFoodItem(FoodItem foodItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FoodItem> GetAllFoodItems()
        {
            throw new NotImplementedException();
        }

        public FoodItem GetFoodItemsById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateFoodItem(FoodItem foodItem)
        {
            throw new NotImplementedException();
        }
    }
}
