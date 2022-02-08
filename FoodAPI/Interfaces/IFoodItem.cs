using FoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.Interfaces
{
    public interface IFoodItem
    {
        IEnumerable<FoodItem> GetAllFoodItems();
        FoodItem GetFoodItemsById(int id);
        void CreateFoodItem(FoodItem foodItem);
        void UpdateFoodItem(FoodItem foodItem);
        void DeleteFoodItem(FoodItem foodItem);
        bool SaveChanges();
    }
}
