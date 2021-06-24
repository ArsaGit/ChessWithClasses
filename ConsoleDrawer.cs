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
			string[] buttons = menu.GetButtons();

			Console.WriteLine("Chess\n");

			for (int i = 0; i < buttons.Length; i++)
			{
				if (menu.isCurrentButton(i))
				{
					Console.ForegroundColor = menu.GetSelectedColor();
				}
				else
				{
					Console.ForegroundColor = menu.GetDefaultTextColor();
				}
				Console.WriteLine(buttons[i]);
			}

			menu.ResetColor();
		}

		public void DrawNewGame()
		{
			
		}

		public void DrawContinueGame()
		{
			Console.WriteLine("Тут однажды будет Continue Game");
		}

		public void DrawRating()
		{
			Console.WriteLine("Тут однажды будет Rating");
		}

		public void DrawExit()
		{
			Console.WriteLine("Тут однажды будет Exit");
		}
	}
}
