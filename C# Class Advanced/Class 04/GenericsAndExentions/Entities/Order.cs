using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExentions.Entities
{
    public class Order : BaseEntitiy<Order>
    {
        public Order(int id) : base(id)
        {
        }
    }
}
