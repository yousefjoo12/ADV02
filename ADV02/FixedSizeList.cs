using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
	public class FixedSizeList<T>
	{
		private T[] items;
		private int capacity;
		private int count;

		public FixedSizeList(int capacity)
		{
			this.capacity = capacity;
			this.items = new T[capacity];
			this.count = 0;
		}

		public void Add(T item)
		{
			if (count < capacity)
			{
				items[count] = item;
				count++;
			}
			else
			{
				Console.WriteLine("Cannot add more elements");
			}
		}

		public T Get(int index)
		{
			if (index < 0 || index >= count)
			{
				Console.WriteLine("Index is out of range ");
				return default(T);
			}

			return items[index];
		}
	}
}
