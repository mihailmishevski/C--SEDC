using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDb.Database
{
    public class InMemoryDatabase
    {
        public static CartDatabase CartDatabase = new CartDatabase();
        public static ItemDatabase ItemDatabase = new ItemDatabase();
    }
}
