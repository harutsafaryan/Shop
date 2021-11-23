using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IBaseRepository<T>
    {
        void Add(T item);
        T Get(Guid id);
        List<T> GetAll();
        void Update(T item, int index);
        bool Delete(T item);
        int IndexOf(T item);
    }
}
