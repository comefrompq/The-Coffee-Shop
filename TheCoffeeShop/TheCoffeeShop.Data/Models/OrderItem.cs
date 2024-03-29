﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeShop.Data.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


        public int Quanity { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }

    }
}
