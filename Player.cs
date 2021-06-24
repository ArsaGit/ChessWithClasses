using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public class Player
	{
		private readonly string name;

		public Player(string name)
		{
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}
	}
}
