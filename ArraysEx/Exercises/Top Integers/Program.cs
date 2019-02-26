using System;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		int[] numbers = Console.ReadLine().Split(" ")
			.Select(int.Parse)
			.ToArray();
		int index = 0;

		foreach (int number in numbers)
		{
			bool isTopInt = true;

			for (int i = index + 1; i < numbers.Length; i++)
			{
				if (number <= numbers[i])
				{
					isTopInt = false;
				}
			}

			if (isTopInt)
			{
				Console.Write(number + " ");
			}

			index++;
		}
	}
}

