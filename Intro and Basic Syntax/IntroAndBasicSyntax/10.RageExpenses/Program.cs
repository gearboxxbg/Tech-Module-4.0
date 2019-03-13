using System;

class Program
{
	static void Main(string[] args)
	{
		int lostGames = int.Parse(Console.ReadLine());
		double headSetPrice = double.Parse(Console.ReadLine());
		int trashedHeadSet = 0;
		double mousePrice = double.Parse(Console.ReadLine());
		int trashedMouse = 0;
		double keyboardPrice = double.Parse(Console.ReadLine());
		int trashedKeyboard = 0;
		double displayPrice = double.Parse(Console.ReadLine());
		int trashedDisplay = 0;
		int displayCount = 0;
		double rageExpenses = 0;

		for (int i = 1; i <= lostGames; i++)
		{
			if (i % 2 == 0)
			{
				trashedHeadSet++;
			}

			if (i % 3 == 0)
			{
				trashedMouse++;
			}

			if (i % 2 == 0 && i % 3 == 0)
			{
				trashedKeyboard++;

				if (trashedKeyboard % 2 == 0)
				{
					displayCount = 1;
				}
			}

			if (trashedKeyboard % 2 == 0 && displayCount == 1)
			{
				trashedDisplay++;
				displayCount = 0;
			}
		}

		rageExpenses = (trashedHeadSet * headSetPrice)
			+ (trashedMouse * mousePrice)
			+ (trashedKeyboard * keyboardPrice)
			+ (trashedDisplay * displayPrice);

		Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
	}
}
