using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RoShambo
{
	class User_Player : Player
	{
		public User_Player() { }
		public User_Player(string name) :base (name)
		{
			Name = name;
		}
		public override Roshambo GenerateRoshambo()
		{

			string message = Validator.GetUserInput("Please choose your Roshambo throw, \"Paper\", \"Scissors\", or \"Rock\"");
			if (message == "Rock")
			{
				return Roshambo.Rock;
			}
			else if (message == "Paper")
			{
				return Roshambo.Paper;
			}
			else if (message == "Scissors")
			{
				return Roshambo.Scissors;
			} 
			else
			{
				Console.WriteLine("No" );
				return GenerateRoshambo();
			}
		}
	}
}
