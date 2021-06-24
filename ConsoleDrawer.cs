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
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("Chess\n");

			string[] buttons = menu.GetButtons();
			for(int i = 0;i<buttons.Length;i++)
			{
				if(menu.isCurrentButton(i))
				{
					Console.ForegroundColor = menu.GetSelectedColor();
				}
				else
				{
					Console.ForegroundColor = menu.GetDefaultTextColor();
				}
				Console.WriteLine(buttons[i]);
			}
		}
	}
}
