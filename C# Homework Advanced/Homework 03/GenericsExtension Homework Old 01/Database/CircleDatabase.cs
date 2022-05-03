using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CircleDatabase : Database<Circle>
    {
        public CircleDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            _shapes.AddRange(new List<Circle>()
            {
                AutoIncrementId(new Circle(6)),
                AutoIncrementId(new Circle(9)),
                AutoIncrementId(new Circle(2))
            });
        }

        public void CircleParameter()
        {
            _shapes.ForEach(x => x.Radius)
        }

        public void CircleArea()
        {
            PrintArea(_shapes);
        }
    }
}
