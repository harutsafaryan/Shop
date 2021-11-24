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
        public Guid _id = Guid.NewGuid();
        public string _name;
        public DateTime _date;
        public List<Product> _products;

        public Enumerator GetEnumerator()
        {
            return new Enumerator(_products, _products.Count);
        }

        public class Enumerator
        {
            public Enumerator(List<Product> product, int size)
            {
                _products = product;
                _size = size;
            }

            private int _size;
            private int _count;
            private List<Product> _products;

            public Product Current { get { return _products[_count++]; } }

            public bool MoveNext()
            {
                return _count < _size;
            }
        }
    }
}
