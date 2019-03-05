using System;

class Program
{
	static void Main(string[] args)
	{
		int numberOfPeople = int.Parse(Console.ReadLine());
		string type = Console.ReadLine();
		string day = Console.ReadLine();
		double price = 0.00;

		if (type == "Students")
		{
			if (day == "Friday")
			{
				price = numberOfPeople * 8.45;
			}

			else if (day == "Saturday")
			{
				price = numberOfPeople * 9.80;
			}

			else if (day == "Sunday")
			{
				price = numberOfPeople * 10.46;
			}

			if (numberOfPeople >= 30)
			{
				price *= 0.85;
			}
		}

		else if (type == "Business")
		{
			if (numberOfPeople >= 100)
			{
				numberOfPeople -= 10;
			}

			if (day == "Friday")
			{
				price = numberOfPeople * 10.9;
			}

			else if (day == "Saturday")
			{
				price = numberOfPeople * 15.6;
			}

			else if (day == "Sunday")
			{
				price = numberOfPeople * 16;
			}
		}

		else if (type == "Regular")
		{
			if (day == "Friday")
			{
				price = numberOfPeople * 15;
			}

			else if (day == "Saturday")
			{
				price = numberOfPeople * 20;
			}

			else if (day == "Sunday")
			{
				price = numberOfPeople * 22.5;
			}

			if (numberOfPeople >= 10 && numberOfPeople <= 20)
			{
				price *= 0.95;
			}
		}
		
		Console.WriteLine($"Total price: {Math.Round(price, 2):F2}");
	}
}