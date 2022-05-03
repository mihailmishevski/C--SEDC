using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public class Pear : Box<Pear>
    {
        public Pear(int id) : base(id)
        {
        }
    }
}
