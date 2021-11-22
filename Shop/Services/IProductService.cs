using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IProductService
    {
        void Add(Product item);
        Product Get(Guid id);
        void Update(Product item);
        bool Delete(Product item);
    }
}

