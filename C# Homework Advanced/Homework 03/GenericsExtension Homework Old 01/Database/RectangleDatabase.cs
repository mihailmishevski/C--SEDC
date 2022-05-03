using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public class RectangleDatabase : Database<Rectangle>
    {
        public RectangleDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            _shapes.AddRange(new List<Rectangle>()
            {
                AutoIncrementId(new Rectangle(5, 6)),
                AutoIncrementId(new Rectangle(4, 9)),
                AutoIncrementId(new Rectangle(1, 2))
            });
        } 

        public List<Rectangle> PrintRectangle()
        {
            return _shapes;
        }

        public void RectangleParameter()
        {
            PrintParameter(_shapes);
        }

        public void CircleArea()
        {
            PrintArea(_shapes);
        }
    }
}
