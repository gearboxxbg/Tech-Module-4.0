﻿using System;
using System.Linq;


class Program
{
	static void Main(string[] args)
	{
		int[] numbers = Console.ReadLine().Split(' ')
			.Select(int.Parse)
			.ToArray();

		for (int i = 0; i < numbers.Length; i++)
		{
			int leftSum = 0;
			int rightSum = 0;

			for (int j = 0; j < i; j++)
			{
				leftSum = leftSum + numbers[j];
			}

			for (int j = i + 1; j < numbers.Length; j++)
			{
				rightSum = rightSum + numbers[j];
			}

			if (leftSum == rightSum)
			{
				Console.WriteLine(i);
				return;
			}
		}

		Console.WriteLine("no");
	}
}

