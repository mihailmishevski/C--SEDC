using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Entities
{
    public class Item : BaseEntity<Item>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Item(int id, string name, int quantitiy) : base(id)
        {
            Name = name;
            Quantity = quantitiy;
        }
    }
}
