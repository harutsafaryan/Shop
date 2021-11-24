using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class BaseRepository<T> : IBaseRepository<T>
    {
        public List<T> items;
        public BaseRepository()
        {
            items = new List<T>();
        }

        public virtual void Add(T item)
        {
            items.Add(item);
        }

        public bool Delete(T item)
        {
            return items.Remove(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public  int IndexOf(T item)
        {
            return items.IndexOf(item);
        }

        public virtual void Update(T item, int index)
        {
            items[index] = item;
        }
    }
}
