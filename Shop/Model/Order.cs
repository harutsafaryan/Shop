﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order : Base
    {
        public DateTime _date;
        public List<Product> _products;
    }
}
