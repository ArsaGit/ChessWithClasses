using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public class ConsoleDrawer : IDrawer
	{
		public void Draw(Menu menu)
		{
			string[] buttons = menu.GetButtons();
			for(int i = 0;i<buttons.Length;i++)
			{
				Console.WriteLine(buttons[i]);
			}
		}

	}
}
