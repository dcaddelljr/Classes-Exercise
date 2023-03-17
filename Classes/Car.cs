using System;
namespace Classes
{
	public class Car
	{
		public Car()
		{
		}
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }

		public void myCar()
		{
			Console.WriteLine($"I own a {Year} {Make} {Model}.");
		}
			
    }
}

