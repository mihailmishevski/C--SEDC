using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public class Cart : BaseEntitiy<Cart>
    {
        public Cart(int id) : base(id)
        {
        }
    }
}
