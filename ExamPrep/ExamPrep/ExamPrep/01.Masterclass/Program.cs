using System;

class Program
{
	static void Main(string[] args)
	{
		float budget = float.Parse(Console.ReadLine());
		int students = int.Parse(Console.ReadLine());
		float priceOfFlour = float.Parse(Console.ReadLine());
		float priceOfEggs = float.Parse(Console.ReadLine());
		float priceOfApron = float.Parse(Console.ReadLine());
		float percentOfApron = ((float)students) + (float)students * 0.2F;
		float apronPrice = priceOfApron * (float)(Math.Ceiling(percentOfApron));
		int freePackages = students / 5;
		float eggsPrice = (priceOfEggs * 10.0F) * (float)students;
		float flourPrice = priceOfFlour * ((float)students - freePackages);
		float totalMoneyForItems = apronPrice + eggsPrice + flourPrice;
		float needMoneyForItems = totalMoneyForItems - budget;

		if (budget >= totalMoneyForItems)
		{
			Console.WriteLine($"Items purchased for {totalMoneyForItems:F2}$.");
		}
		else
		{
			Console.WriteLine($"{needMoneyForItems:F2}$ more needed.");
		}
	}
}
