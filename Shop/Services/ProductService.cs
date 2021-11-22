using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product item)
        {
            _productRepository.Add(item);
        }

        public bool Delete(Product item)
        {
            return _productRepository.Delete(item);
        }

        public Product Get(Guid id)
        {
            return _productRepository.Get(id);
        }

        public void Update(Product item)
        {
            Product oldItem = _productRepository.Get(item._id);
            int index = _productRepository.IndexOf(oldItem);
            _productRepository.Update(item, index);
        }
    }
}
