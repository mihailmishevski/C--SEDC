using AdvancedLINQ.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Entities
{
    public class Subject
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPartyTime { get; set; }

        public Academy Academy { get; set; }

        public Subject(int id, string name, Academy academy)
        {
            Id = id;
            Name = name;
            Academy = academy;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
