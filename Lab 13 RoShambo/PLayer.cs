using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RoShambo
{
	abstract class Player
	{
		public string Name { get; set; }

		public Roshambo Roshambo { get; set; }

		public Player(string name)
		{
			Name = name;
		}
		public Player() { }

		public abstract Roshambo GenerateRoshambo();
	}
}
