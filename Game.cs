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
			RunMenu();
			ActivateButton();
		}

		private void RunMenu()
		{
			do
			{
				menu.Draw();
				menu.SelectButton();
			} while (menu.IsRunning());
		}

		private void ActivateButton()
		{
			Console.Clear();
			int key = menu.GetNumberOfCurrentButton();

			switch(key)
			{
				case 0:
					StartNewGame();
					break;
				case 1:
					ContinueGame();
					break;
				case 2:
					OpenRating();
					break;
				case 3:
					ExitApp();
					break;
			}
		}

		private void StartNewGame()
		{
			drawer.DrawNewGame();
		}

		private void ContinueGame()
		{
			drawer.DrawContinueGame();
		}

		private void OpenRating()
		{
			drawer.DrawRating();
		}

		private void ExitApp()
		{
			drawer.DrawExit();
		}
	}
}
