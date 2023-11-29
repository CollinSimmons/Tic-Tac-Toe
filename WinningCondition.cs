using System;
namespace Practice
{
	public class WinningCondition
	{
        
        public void xWin(Board board)
		{
            for (int i = 0; i == 0; i++)
            {
            var xwin = board.grid[0, 0] == Element.X && board.grid[0, 1] == Element.X && board.grid[0, 2] == Element.X ||
                       board.grid[1, 0] == Element.X && board.grid[1, 1] == Element.X && board.grid[1, 2] == Element.X ||
                       board.grid[2, 0] == Element.X && board.grid[2, 1] == Element.X && board.grid[2, 2] == Element.X ||
                       board.grid[0, 0] == Element.X && board.grid[1, 0] == Element.X && board.grid[2, 0] == Element.X ||
                       board.grid[0, 1] == Element.X && board.grid[1, 1] == Element.X && board.grid[2, 1] == Element.X ||
                       board.grid[0, 2] == Element.X && board.grid[1, 2] == Element.X && board.grid[2, 2] == Element.X ||
                       board.grid[0, 0] == Element.X && board.grid[1, 1] == Element.X && board.grid[2, 2] == Element.X ||
                       board.grid[0, 2] == Element.X && board.grid[1, 1] == Element.X && board.grid[2, 0] == Element.X;
            if (xwin)
            {
                Console.WriteLine("Player X has won!");
                break;
            }
            }
            

        }
        public void oWin(Board board)
        {
            var owin = board.grid[0, 0] == Element.O && board.grid[0, 1] == Element.O && board.grid[0, 2] == Element.O ||
                       board.grid[1, 0] == Element.O && board.grid[1, 1] == Element.O && board.grid[1, 2] == Element.O ||
                       board.grid[2, 0] == Element.O && board.grid[2, 1] == Element.O && board.grid[2, 2] == Element.O ||
                       board.grid[0, 0] == Element.O && board.grid[1, 0] == Element.O && board.grid[2, 0] == Element.O ||
                       board.grid[0, 1] == Element.O && board.grid[1, 1] == Element.O && board.grid[2, 1] == Element.O ||
                       board.grid[0, 2] == Element.O && board.grid[1, 2] == Element.O && board.grid[2, 2] == Element.O ||
                       board.grid[0, 0] == Element.O && board.grid[1, 1] == Element.O && board.grid[2, 2] == Element.O ||
                       board.grid[0, 2] == Element.O && board.grid[1, 1] == Element.O && board.grid[2, 0] == Element.O;
            if (owin)
            {
                Console.WriteLine("Player O has won!");
            }


        }
    }
}

	