using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithClasses
{
	public abstract class Figure
	{
		public abstract char OneLetter { get; }
		public abstract string Name { get; }

		//public bool isWhite;

		public char ToChar()
		{
			return OneLetter;
		}
	}

	public class Pawn : Figure
	{
		public override char OneLetter => 'P';
		public override string Name => "Пешка";
	}

	public class Bishop : Figure
	{
		public override char OneLetter => 'B';
		public override string Name => "Слон";
	}

	public class Knight : Figure
	{
		public override char OneLetter => 'N';
		public override string Name => "Конь";
	}

	public class Rook : Figure
	{
		public override char OneLetter => 'R';
		public override string Name => "Ладья";
	}

	public class Queen : Figure
	{
		public override char OneLetter => 'Q';
		public override string Name => "Королева";
	}

	public class King : Figure
	{
		public override char OneLetter => 'K';
		public override string Name => "Король";
	}
}
