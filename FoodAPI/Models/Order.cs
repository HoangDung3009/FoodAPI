using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public int Ototal { get; set; }

        public virtual Cusomter Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
