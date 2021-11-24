using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public interface IOrderService
    {
        void Add(Order item);
        Order Get(Guid id);
        void Update(Order item);
        bool Delete(Order item);
        List<Order> GetAll();
    }
}
