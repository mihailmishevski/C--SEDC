using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public class Apple : Box<Apple>
    {
        public Apple(int id) : base(id)
        {
        }
    }
}
