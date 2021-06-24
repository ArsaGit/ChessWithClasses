using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public class Match
	{
		private readonly IDrawer drawer;
		private Player player1;
		//private Player player2;

		enum FigureType
		{
			Pawn = 'P', Bishop = 'B', Knight = 'N',
			Rook = 'R', Queen = 'Q', King = 'K'
		}

		private Figure[,] board;

		public Match(IDrawer drawer, Player player1)
		{
			this.drawer = drawer;
			this.player1 = player1;
			//this.player2 = player2;

			board = new Figure[,]{
				{ null, null, null, null, null, null, null, null},
				{ null, null, null, null, null, null, null, null},
				{ null, null, null, null, null, null, null, null},
				{ null, null, null, null, null, null, null, null},
				{ null, null, null, null, null, null, null, null},
				{ null, null, null, null, null, null, null, null},
				{ new Pawn(), new Pawn(), new Pawn(), new Pawn(), new Pawn(), new Pawn(), new Pawn(), new Pawn()},
				{ new Rook(), new Knight(), new Bishop(), new Queen(), new King(), new Bishop(), new Knight(), new Rook()}
			};
		}

		public void Run()
		{

		}

		private void MakeTurn()
		{

		}

		public void Draw()
		{
			drawer.Draw(this);
		}

		public Figure[,] GetBoard()
		{
			return board;
		}


	}
}
