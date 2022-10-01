using System;
using System.Linq;

namespace codility
{
	class Program
	{
		public static int solution(int[] A)
		{
			var min = 1;
			var minPos = Enumerable.Range(1, A.Max() + 1);

			if(minPos.Count() == 0)
			{
				return min;
			}
			
			foreach (var item in minPos)
			{
				if (!A.Distinct().Contains(item))
				{
					min = item;
					break;
				}				
			}

			return min;

		}

		static void Main(string[] args)
		{
			var A = new int[] { 10, 20, 1, 2, 3 , 4, 5, 6, 7, 8};
			Console.WriteLine($"Solution: {solution(A)}");

			var B = new int[] { -1, -3 };
			Console.WriteLine($"Solution: {solution(B)}");

			Console.ReadKey();
		}
	}
}
