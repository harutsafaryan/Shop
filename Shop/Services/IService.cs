using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IService<T>
    {
        void Add(T item);
        T Get(Guid id);
        void Update(T item);
        bool Delete(T item);
    }
}
