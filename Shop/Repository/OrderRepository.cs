using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repository
{
    class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public override Order Get(Guid id)
        {
            return items.FirstOrDefault(x => x._id == id);
        }
    }
}
