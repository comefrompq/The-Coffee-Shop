﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeShop.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }

    }
}
