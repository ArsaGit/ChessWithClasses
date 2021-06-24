using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public interface IDrawer
	{
		//void Draw(Game game);
		void Draw(Menu menu);
		public void DrawNewGame();
		public void DrawContinueGame();
		public void DrawRating();
		public void DrawExit();
	}
}
