using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Entities
{
    public abstract class BaseEntity<T>
    {
        public int Id { get; set; }

        public BaseEntity(int id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            var other = obj as BaseEntity<T>;

            if(other == null)
            {
                return false;
            }

            return Id == other.Id;
        }
    }
}
