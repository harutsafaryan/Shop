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

        public decimal GetOrderPrice(Guid id)
        {
            Order order = _orderRepository.Get(id);
            decimal sum = 0;
            foreach (var item in order._products)
            {
                sum += item._price;
            }

            return sum;
        }

        public int GetProductCount(Guid id)
        {
            Order order = _orderRepository.Get(id);
            int count = 0;
            foreach (var item in order._products)
            {
                count++;
            }
            return count;
        }

        public void Update(Order item)
        {
            Order oldItem = _orderRepository.Get(item._id);
            int index = _orderRepository.IndexOf(oldItem);
            _orderRepository.Update(item, index);
        }
    }
}
