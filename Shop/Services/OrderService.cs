using Shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Add(Order item)
        {
            _orderRepository.Add(item);
        }

        public bool Delete(Order item)
        {
            return _orderRepository.Delete(item);
        }

        public Order Get(Guid id)
        {
            return _orderRepository.Get(id);
        }

        public void Update(Order item)
        {
            Order oldItem = _orderRepository.Get(item.Id);
            int index = _orderRepository.IndexOf(oldItem);
            _orderRepository.Update(item, index);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }
    }
}
