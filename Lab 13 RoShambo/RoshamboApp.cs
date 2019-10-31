using System;

namespace Lab_13_RoShambo
{
	class Program
	{
		static int randomWins = 0;
		static int rockKrocWins = 0;
		static int userWins = 0;
		static int ties = 0;
		static bool more = true;

		static void Main(string[] args)
		{
			Random_Player playerRandom = new Random_Player();
			playerRandom.Name = "Randominater";
			
			Rock_Player playerRock = new Rock_Player();
			playerRock.Name = "RockKroc";
			Roshambo rockPlay = playerRock.GenerateRoshambo();

			User_Player playerUser = new User_Player();
			Console.WriteLine("Please enter your name: ");
			playerUser.Name = Console.ReadLine();

			do
			{
				Roshambo randomPlay = playerRandom.GenerateRoshambo();
				string userInput = Validator.OpponentSelector();
				Roshambo userPlay = playerUser.GenerateRoshambo();

				switch (userInput)
				{
					case "1":
					case "Randominater":
						VersusRandomOpponent(playerRandom, playerUser, randomPlay, userPlay);
						break;
					case "2":
					case "RockKroc":
						VersusRockOpponent(playerRock, playerUser, rockPlay, userPlay);
						break;

				}

				string goAgain = Validator.GetUserInput("Would you like to play again? (y/n)?");
					if (goAgain == "n")
					{
						more = false;
					}
					else
					{
						more = true;
					}
			}
			while (more);
			Console.WriteLine("Have a good day!");
		}
		public static void VersusRockOpponent(Rock_Player playerRock, User_Player playerUser, Roshambo rockPlay, Roshambo userThrow)
		{
				if (rockPlay == Roshambo.Rock && userThrow == Roshambo.Rock)
				{
					
					Console.WriteLine($"{playerRock.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("It's A Tie");
					Console.ResetColor();
					ties++;
				}
				if (rockPlay == Roshambo.Rock && userThrow == Roshambo.Paper)
				{
					Console.WriteLine($"{playerRock.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{playerUser.Name} Wins");
					Console.ResetColor();
					userWins++;
				}
				if (rockPlay == Roshambo.Rock && userThrow == Roshambo.Scissors)
				{
					Console.WriteLine($"{playerRock.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"{playerRock.Name} Wins");
					Console.ResetColor();
					rockKrocWins++;
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("RockKroc Wins" + rockKrocWins);

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine($"{playerUser.Name} Wins" + userWins);

				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Tie Wins" + ties);
			
		}
		public static void VersusRandomOpponent(Random_Player playerRandom, User_Player playerUser, Roshambo randomPlay, Roshambo userThrow)
		{
				if (randomPlay == Roshambo.Rock && userThrow == Roshambo.Rock)
				{
					Console.WriteLine($"{playerRandom.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Tie Wins");
					Console.ResetColor();
					ties++;
				}
				if (randomPlay == Roshambo.Rock && userThrow == Roshambo.Paper)
				{
					Console.WriteLine($"{playerRandom.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{playerUser.Name} Wins");
					Console.ResetColor();
					userWins++;
				}
				if (randomPlay == Roshambo.Rock && userThrow == Roshambo.Scissors)
				{
					Console.WriteLine($"{playerRandom.Name} threw Rock and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine($"{playerRandom.Name} Wins");
					Console.ResetColor();
					randomWins++;
				}
				if (randomPlay == Roshambo.Paper && userThrow == Roshambo.Paper)
				{
					Console.WriteLine($"{playerRandom.Name} threw Paper and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Tie Wins");
					Console.ResetColor();
					ties++;
				}
				if (randomPlay == Roshambo.Paper && userThrow == Roshambo.Rock)
				{
					Console.WriteLine($"{playerRandom.Name} threw Paper and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine($"{playerRandom.Name} Wins");
					Console.ResetColor();
					randomWins++;
				}
				if (randomPlay == Roshambo.Paper && userThrow == Roshambo.Scissors)
				{
					Console.WriteLine($"{playerRandom.Name} threw Paper and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{playerUser.Name} Wins");
					Console.ResetColor();
					userWins++;
				}
				if (randomPlay == Roshambo.Scissors && userThrow == Roshambo.Paper)
				{
					Console.WriteLine($"{playerRandom.Name} threw Scissors and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine($"{playerRandom.Name} Wins");
					Console.ResetColor();
					randomWins++;
				}
				if (randomPlay == Roshambo.Scissors && userThrow == Roshambo.Scissors)
				{
					Console.WriteLine($"{playerRandom.Name} threw Scissors and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Tie Wins");
					Console.ResetColor();
					ties++;
				}
				if (randomPlay == Roshambo.Scissors && userThrow == Roshambo.Rock)
				{
					Console.WriteLine($"{playerRandom.Name} threw Scissors and {playerUser.Name} threw {userThrow}.");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{playerUser.Name} Wins");
					Console.ResetColor();
					userWins++;
				}

				Console.ForegroundColor = ConsoleColor.DarkMagenta;
				Console.WriteLine("Random Wins" + randomWins);

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine($"{playerUser.Name} Wins" + userWins);

				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Tie Wins" + ties);
		}
	}
}
