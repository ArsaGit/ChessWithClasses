using System;

namespace ChessWithClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Game chess = new Game(new ConsoleDrawer());
			chess.Run();
		}
	}
}
