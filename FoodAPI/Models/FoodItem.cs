using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAPI.Models
{
    public partial class FoodItem
    {
        public FoodItem()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int FoodItemId { get; set; }
        public string FootItemName { get; set; }
        public double Price { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
