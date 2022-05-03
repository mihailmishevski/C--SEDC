using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public abstract class Database<T> where T : Shape
	{
		protected static List<T> _shapes;

		static Database()
		{
			_shapes = new List<T>();
		}

		public void Insert(T items)
		{
			T shapeToInsert = AutoIncrementId(items);

			_shapes.Add(shapeToInsert);
		}

		public T AutoIncrementId(T items)
        {
			int currentId = 0;

			if(_shapes.Count > 0)
            {
				currentId = _shapes.OrderByDescending(x => x.Id).First().Id;
            }

			items.Id = currentId++;

			return items;
        }

		public void PrintParameter(List<T> shape)
		{
			shape.ForEach(x => x.GetParameter());
		}

		public void PrintArea(List<T> shape)
		{
			shape.ForEach(x => x.GetArea());
		}
	}
}
