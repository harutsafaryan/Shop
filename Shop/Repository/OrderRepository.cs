﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repository
{
    class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public Order Get(Guid id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
    }
}
