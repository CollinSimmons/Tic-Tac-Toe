
using System;
namespace Practice
{

	public class Player
	{
            
            Element element;
            Element op;

            public Player(Element el, Element opposition)
            {
                element = el;
                op = opposition;
            }

            public void Play(Board board)
            {
            
            var a = Console.ReadLine();
            if (a == "topleft")
            {
                if (board.grid[0, 0] == op)
                {
                    Console.WriteLine("Not an empty space. Please try again.");
                }
                else
                {
                    board.grid[0, 0] = element;
                }
            }
            else if (a == "topmiddle")
            {
                if (board.grid[0, 1] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[0, 1] = element;
                }
            }
            else if (a == "topright")
            {
                if (board.grid[0, 2] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[0, 2] = element;
                }
            }
            else if (a == "middleleft")
            {
                if (board.grid[1, 0] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[1, 0] = element;
                }
            }
            else if (a == "middlemiddle")
            {
                if (board.grid[1, 1] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[1, 1] = element;
                }
            }
            else if (a == "middleright")
            {
                if (board.grid[1, 2] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[1, 2] = element;
                }
            }
            else if (a == "bottomleft")
            {
                if (board.grid[2, 0] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[2, 0] = element;
                }
            }
            else if (a == "bottommiddle")
            {
                if (board.grid[2, 1] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[2, 1] = element;
                }
            }
            else if (a == "bottomright")
            {
                if (board.grid[2, 2] == op)
                {
                    Console.WriteLine("Not an empty space");
                }
                else
                {
                    board.grid[2, 2] = element;
                }
            }
        }
    }
}
   

