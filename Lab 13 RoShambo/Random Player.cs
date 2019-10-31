using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RoShambo
{
	class Random_Player : Player
	{ 
		public Random_Player(string name) : base(name)
		{
		}
		public Random_Player() { }
		public override Roshambo GenerateRoshambo()
		{
			Random random = new Random();

			int number = random.Next(0, 3);
			
			switch (number)
			{
				case 0:
					return Roshambo.Rock;
				case 1:
					return Roshambo.Paper;
				case 2:
					return Roshambo.Scissors;
			}
			return Roshambo.Rock;
		}
	}
}
