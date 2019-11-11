using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeShop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool OrderStatus { get; set; }
        public int TotalPrice { get; set; }
        public int User { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }

    }

}
