using System;

class Program
{
	static void Main(string[] args)
	{
		int wagons = int.Parse(Console.ReadLine());
		int[] passengers = new int[wagons];
		int sum = 0;

		for (int i = 0; i < wagons; i++)
		{
			int number = int.Parse(Console.ReadLine());
			passengers[i] = number;
			sum += number;
		}

		for (int i = 0; i < wagons; i++)
		{
			Console.Write(passengers[i] + " ");
		}

		Console.WriteLine();
		Console.WriteLine(sum);
	}
}
}