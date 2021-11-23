using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public override Product Get(Guid id)
        {
            return items.FirstOrDefault(x => x._id == id);
        }
    }
}
