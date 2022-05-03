using GenericDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Database
{
    public abstract class Database<T> where T : BaseEntity<T>
    {
        private readonly List<T> _entities;

        public Database()
        {
            _entities = new List<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T Get(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        protected List<T> GetAll()
        {
            return _entities;
        }
    }
}
