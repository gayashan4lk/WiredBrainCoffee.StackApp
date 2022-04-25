using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T> where T : class, IEntity
    {
        protected readonly List<T> _items = new List<T>();

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);

            //return null;
            //return default(T);
            //return default;
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            //item.Id = _items.Any() ? _items.Max(item => item.Id) + 1 : 1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
