using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public class Menu
	{
		private readonly IDrawer drawer;
		private readonly string[] buttons = {"New game",
							"Continue",
							"Rating",
							"Exit"};

		private int currentButtonNumber = 0;
		private const ConsoleColor SelectedColor = ConsoleColor.Green;

		public Menu(IDrawer drawer)
		{
			this.drawer = drawer;
		}

		public void Draw()
		{
			drawer.Draw(this);
		}

		public string[] GetButtons()
		{
			return buttons;
		}

		public int GetNumberOfCurrentButton()
		{
			return currentButtonNumber;
		}

		public ConsoleColor GetSelectedColor()
		{
			return SelectedColor;
		}
	}
}
