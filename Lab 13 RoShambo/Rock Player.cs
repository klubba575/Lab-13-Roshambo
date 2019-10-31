using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RoShambo
{ 
	class Rock_Player : Player
	{
		public Rock_Player(string name) :base (name)
		{
			Name = name;
		}
		public Rock_Player() { }
		public override Roshambo GenerateRoshambo()
		{
			return Roshambo.Rock;
		}
	}
}
