﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public Guid _id = Guid.NewGuid();
        public string _name;
        public decimal _price;
    }
}
