using GenericDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Database
{
    public class ItemDatabase : Database<Item>
    {
        public List<Item> GetItemsWithQuantitiy(int quantity)
        {
            return GetAll().Where(x => x.Quantity == quantity).ToList();
        }
    }
}
