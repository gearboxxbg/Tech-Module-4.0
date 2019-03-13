using System;
using System.Linq;

//not finished
class Program
{
	static void Main(string[] args)
	{
		int initialEnergy = 100;
		int initialCoins = 100;
		string[] events = Console.ReadLine()
			.Split('|')
			.ToArray();

		for (int i = 0; i < events.Length; i++)
		{
			string[] currentEvent = events[i]
				.Split('-')
				.ToArray();
			string command = currentEvent[0];
			string number = currentEvent[1];

			if (command == "rest")
			{
				int currentEnergy = initialEnergy;
				currentEnergy += int.Parse(number);

				if (currentEnergy > 100)
				{
					Console.WriteLine($"You gained {100 - initialEnergy} energy.");
					Console.WriteLine("Current energy: 100");
				}
				else
				{
					Console.WriteLine($"You gained {number} energy.");
					Console.WriteLine($"Current energy: {currentEnergy}");
				}
			}
			else if (command == "order")
			{
				if (initialEnergy >= 30)
				{
					initialCoins += int.Parse(number);
				}
			}

		}
	}
}

