using System;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		int number = int.Parse(Console.ReadLine());
		int[] firstArray = new int[number];
		int[] secondArray = new int[number];
		int count = 0;

		for (int i = 0; i < number; i++)
		{
			int[] values = Console.ReadLine().Split(" ")
				.Select(int.Parse)
				.ToArray();

			if (i % 2 == 0)
			{
				firstArray[count] = values[0];
				secondArray[count] = values[1];
				count++;
			}
			else if (i % 2 != 0)
			{
				firstArray[count] = values[1];
				secondArray[count] = values[0];
				count++;
			}
		}

		Console.WriteLine(string.Join(" ", firstArray));
		Console.WriteLine(string.Join(" ", secondArray));
	}
}

