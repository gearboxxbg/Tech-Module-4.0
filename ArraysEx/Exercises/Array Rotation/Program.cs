using System;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		int[] numbers = Console.ReadLine().Split(" ")
		.Select(int.Parse)
		.ToArray();
		int rotations = int.Parse(Console.ReadLine());

		if (rotations > numbers.Length)
		{
			rotations -= numbers.Length;
		}
		else if (rotations == numbers.Length)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
			return;
		}

		int index = 0;
		int[] resultArray = new int[numbers.Length];

		for (int i = rotations; i< numbers.Length; i++)
		{
			resultArray[index] = numbers[i];
			index++;
		}

		for (int i = 0; i < rotations; i++)
		{
			resultArray[index] = numbers[i];
			index++;
		}

		for (int i = 0; i < resultArray.Length; i++)
		{
			Console.Write(resultArray[i] + " ");
		}

		Console.WriteLine();
	}
}
