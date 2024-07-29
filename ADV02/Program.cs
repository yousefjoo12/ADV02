using System.Buffers.Text;
using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADV02
{

	internal class Program
	{
		public static void ReverseArrayList(ArrayList list)
		{
			int n = list.Count;
			for (int i = 0; i < n / 2; i++)
			{
				object temp = list[i];

				list[i] = list[n - i - 1];
				list[n - i - 1] = temp;
			}
		}


		public static List<int> GetEvenNumbers(List<int> inputList)
		{
			List<int> EvenNumbers = new List<int>();

			foreach (int num in inputList)
			{
				if (num % 2 == 0)
				{
					EvenNumbers.Add(num);
				}

			}

			return EvenNumbers;
		}

		static void Main(string[] args)
		{
			#region Generic collection

			#region List

			//1.List < T >
			//Time Complexity
			//Search: O(n)
			//Insertion at end: O(1)
			//Insertion in middle: O(n)
			//Insertion in start: O(n)

			//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; 
			#endregion

			#region Dictionary
			//2.Dictionary < TKey, TValue >
			//Time Complexity:

			//Search: O(1)
			//Insertion : O(1)
			// unique elements
			//Dictionary<string, int> joo = new Dictionary<string, int>();

			#endregion

			#region Queue
			//3-Queue
			//FIFO(First In First Out) data structure Or last in last out

			//Elements are added at the end and removed from the front.
			//Time Complexity
			//Enqueue: O(1)
			//Dequeue: O(1)
			//Peek: O(1)
			//Queue<int> queue = new Queue<int>();

			#endregion

			#region Stack
			// 4- Stack<T> 
			//FILO(First In Last Out) data structure Or Last in first Out
			//Enqueue: O(1)
			//Dequeue: O(1)
			//Peek: O(1)
			//Stack<int> stack = new Stack<int>();

			#endregion

			#endregion

			#region 1
			//ArrayList arrayList = new ArrayList() { 1, 2, 3, 4 };

			//Console.WriteLine("befor reverse");
			//foreach (var item in arrayList)
			//{
			//	Console.Write(item);
			//}

			//ReverseArrayList(arrayList);

			//Console.WriteLine("\nAfter reverse");

			//foreach (var item in arrayList)
			//{
			//	Console.Write(item);
			//}
			#endregion
			#region 2
			//List<int> inputList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			//Console.WriteLine(" List number ");
			//foreach (int numers in inputList)
			//{
			//	Console.Write(numers);
			//}

			//List<int> result = GetEvenNumbers(inputList);

			//Console.WriteLine("\nEven Numbers");
			//foreach (int numers in result)
			//{
			//	Console.Write(numers);
			//}
			#endregion

			#region 3
			//FixedSizeList<int> list = new FixedSizeList<int>(3);

			//list.Add(1);
			//list.Add(2);
			//list.Add(3); 

			//list.Add(4);   

			//Console.WriteLine(list.Get(3));
			#endregion
		}
	}
}
