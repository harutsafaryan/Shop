using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
    }
}
