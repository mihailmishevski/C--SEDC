using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public class Box<T>
    {
        public int Id { get; set; }

        public Box(int id)
        {
            Id = id;
        }
    }
}
