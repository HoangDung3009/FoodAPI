using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAPI.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodItemId { get; set; }
        public double FoodItemPrice { get; set; }
        public int Quantity { get; set; }

        public virtual FoodItem FoodItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
