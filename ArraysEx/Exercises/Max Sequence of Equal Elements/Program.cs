using System;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		int longestSeqLength = 1;
		int longestSeqStart = 0;
		int currentSeqLength = 1;
		int currentSeqStart = 0;

		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] == numbers[i - 1])
			{
				currentSeqLength++;

				if (currentSeqLength > longestSeqLength)
				{
					longestSeqLength = currentSeqLength;
					longestSeqStart = currentSeqStart;
				}
			}
			else
			{
				currentSeqLength = 1;
				currentSeqStart = i;
			}
		}

		for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
		{
			Console.Write(numbers[i] + " ");
		}
	}
}
