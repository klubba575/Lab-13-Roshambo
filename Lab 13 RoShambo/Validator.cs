using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RoShambo
{
	class Validator
	{
		public static string GetUserInput(string message)
		{
			Console.WriteLine(message);
			string userName = Console.ReadLine();
			return userName;
		}
		public static string OpponentSelector()
		{
				Console.WriteLine("Select your opponent:");
				Console.WriteLine("1. Randominater");
				Console.WriteLine("2. RockKroc");
				string userInput = Console.ReadLine();
				return userInput;
		}
	}
	
}
