using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Entities
{
    public class Cart : BaseEntity<Cart>
    {
        public string CartId { get; set; }

        public List<Item> Items { get; set; }

        public Cart(int id, string cartId, List<Item> items) : base(id)
        {
            CartId = cartId;
            Items = items;
        }
    }
}
