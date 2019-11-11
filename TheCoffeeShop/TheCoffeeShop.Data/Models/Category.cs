﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}
