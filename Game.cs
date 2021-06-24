using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public class Game
	{
		private readonly IDrawer drawer;
		private Menu menu;

		public Game(IDrawer drawer)
		{
			this.drawer = drawer;
			menu = new Menu(drawer);
		}

		public void Run()
		{
			menu.Draw();
		}
	}
}
