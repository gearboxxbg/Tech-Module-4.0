using System;

	class Program
	{
		static void Main(string[] args)
		{
			int inputNum = int.Parse(Console.ReadLine());
			long checkNum = inputNum;
			long factorielSum = 0;

			while (checkNum != 0)
			{
				long result = checkNum % 10;
				checkNum /= 10;

				long factorial = 1;
				for (int i = 1; i <= result; i++)
				{
					factorial *= i;
				}
				factorielSum += factorial;
			}

			if (factorielSum == inputNum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
