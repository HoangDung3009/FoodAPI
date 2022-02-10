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
            if(foodItem == null)
            {
                throw new ArgumentNullException(nameof(foodItem));
            }
            _context.FoodItems.Add(foodItem);
        }

        public void DeleteFoodItem(FoodItem foodItem)
        {
            if (foodItem == null)
            {
                throw new ArgumentNullException(nameof(foodItem));
            }
            _context.FoodItems.Remove(foodItem);
        }

        public IEnumerable<FoodItem> GetAllFoodItems()
        {
            return _context.FoodItems.ToList();
        }

        public FoodItem GetFoodItemsById(int id)
        {
            return _context.FoodItems.FirstOrDefault(x => x.FoodItemId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateFoodItem(FoodItem foodItem)
        {
            //
        }
    }
}
