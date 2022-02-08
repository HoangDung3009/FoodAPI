using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAPI.Models
{
    public partial class Cusomter
    {
        public Cusomter()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
