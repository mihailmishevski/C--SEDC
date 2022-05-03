using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public abstract class BaseEntitiy<T>
    {
        public int Id { get; set; }

        protected BaseEntitiy(int id)
        {
            Id = id;
        }

        public bool IsEqualTo(BaseEntitiy<T> obj)
        {
            return Id == obj.Id;
        }
    }
}
