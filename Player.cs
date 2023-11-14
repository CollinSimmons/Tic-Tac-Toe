
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
                    //Adding comment to improve something
                    if (board.grid[0, 0] == op)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        board.grid[0, 0] = element;
                    }
                }
            }
        }
    
	
}

