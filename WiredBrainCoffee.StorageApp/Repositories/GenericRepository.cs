using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    /*public class EmployeeRepositoryWithRemove : GenericRepository<Employee>
    {
        public void Remove(Employee employee)
        {
            _items.Remove(employee);
        }
    }*/

    public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
