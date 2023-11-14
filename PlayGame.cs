using System;
namespace Practice
{
    public class Practice
    {
       
        static void Main(string[] args)
        {
            
            var Start = new Board();
            Console.WriteLine("Welcome to tic-tac-toe. \nTo make changes type the names of the coordiantes. \n" +
                "For example:\ntopleft\ntopmiddle\ntopright\nmiddleleft\nmiddlemiddle\nmiddleright\nbottomleft\nbottommiddle\nbottomright");
            Start.PrintBoard();
            for (var i = 0; i <= 4; i++)
            {

                var a = Console.ReadLine();
                if (a == "topleft")
                {
                    if (Start.grid[0, 0] == Element.O)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
            {
                Start.grid[0, 0] = Element.X;
            }
        }
                else if (a == "topmiddle")
                {
                    if (Start.grid[0, 1] == Element.O)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[0, 1] = Element.X;
                    }
                }
                else if (a == "topright")
{
    if (Start.grid[0, 2] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[0, 2] = Element.X;
    }
}
else if (a == "middleleft")
{
    if (Start.grid[1, 0] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[1, 0] = Element.X;
    }
}
else if (a == "middlemiddle")
{
    if (Start.grid[1, 1] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[1, 1] = Element.X;
    }
}
else if (a == "middleright")
{
    if (Start.grid[1, 2] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[1, 2] = Element.X;
    }
}
else if (a == "bottomleft")
{
    if (Start.grid[2, 0] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[2, 0] = Element.X;
    }
}
else if (a == "bottommiddle")
{
    if (Start.grid[2, 1] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[2, 1] = Element.X;
    }
}
else if (a == "bottomright")
{
    if (Start.grid[2, 2] == Element.O)
    {
        Console.WriteLine("Not an empty space");
    }
    else
    {
        Start.grid[2, 2] = Element.X;
    }
}
            if (i == 4)
                {
                    break;
                }
                Start.PrintBoard();
                
                if (Start.grid[0, 0] == Element.X && Start.grid[0, 1] == Element.X && Start.grid[0, 2] == Element.X)
                {
                    break;
                }
                if (Start.grid[1, 0] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[1, 2] == Element.X)
                {
                    break;
                }
                if (Start.grid[2, 0] == Element.X && Start.grid[2, 1] == Element.X && Start.grid[2, 2] == Element.X)
                {
                    break;
                }
                /* check for columns */
                if (Start.grid[0, 0] == Element.X && Start.grid[1, 0] == Element.X && Start.grid[2, 0] == Element.X)
                {
                    break;
                }
                if (Start.grid[0, 1] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 1] == Element.X)
                {
                    break;
                }
                if (Start.grid[0, 2] == Element.X && Start.grid[1, 2] == Element.X && Start.grid[2, 2] == Element.X)
                {
                    break;
                }
                /* check for diagonal */
                if (Start.grid[0, 0] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 2] == Element.X)
                {
                    break;
                }
                if (Start.grid[0, 2] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 0] == Element.X)
                {
                    break;
                }
                

                var b = Console.ReadLine();
                if (b == "topleft")
                {
                    if (Start.grid[0, 0] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[0, 0] = Element.O;
                    }
                }
                else if (b == "topmiddle")
                {
                    if (Start.grid[0, 1] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[0, 1] = Element.O;
                    }
                }
                else if (b == "topright")
                {
                    if (Start.grid[0, 2] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[0, 2] = Element.O;
                    }
                }
                else if (b == "middleleft")
                {
                    if (Start.grid[1, 0] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[1, 0] = Element.O;
                    }
                }
                else if (b == "middlemiddle")
                {
                    if (Start.grid[1, 1] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[1, 1] = Element.O;
                    }
                }
                else if (b == "middleright")
                {
                    if (Start.grid[1, 2] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[1, 2] = Element.O;
                    }
                }
                else if (b == "bottomleft")
                {
                    if (Start.grid[2, 0] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[2, 0] = Element.O;
                    }
                }
                else if (b == "bottommiddle")
                {
                    if (Start.grid[2, 1] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[2, 1] = Element.O;
                    }
                }
                else if (b == "bottomright")
                {
                    if (Start.grid[2, 2] == Element.X)
                    {
                        Console.WriteLine("Not an empty space");
                    }
                    else
                    {
                        Start.grid[2, 2] = Element.O;
                    }
                }
                Start.PrintBoard();
                /* chech for rows */
                if (Start.grid[0, 0] == Element.O && Start.grid[0, 1] == Element.O && Start.grid[0, 2] == Element.O)
                {
                    break;
                }
                if (Start.grid[1, 0] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[1, 2] == Element.O)
                {
                    break;
                }
                if (Start.grid[2, 0] == Element.O && Start.grid[2, 1] == Element.O && Start.grid[2, 2] == Element.O)
                {
                    break;
                }
                /* check for columns */
                if (Start.grid[0, 0] == Element.O && Start.grid[1, 0] == Element.O && Start.grid[2, 0] == Element.O)
                {
                    break;
                }
                if (Start.grid[0, 1] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 1] == Element.O)
                {
                    break;
                }
                if (Start.grid[0, 2] == Element.O && Start.grid[1, 2] == Element.O && Start.grid[2, 2] == Element.O)
                {
                    break;
                }
                /* check for diagonal */
                if (Start.grid[0, 0] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 2] == Element.O)
                {
                    break;
                }
                if (Start.grid[0, 2] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 0] == Element.O)
                {
                    break;
                }

            }

            Start.PrintBoard();
            if (Start.grid[0, 0] == Element.X && Start.grid[0, 1] == Element.X && Start.grid[0, 2] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            else if (Start.grid[1, 0] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[1, 2] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            else if (Start.grid[1, 0] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[1, 2] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            /* check for columns */
            else if (Start.grid[0, 0] == Element.X && Start.grid[1, 0] == Element.X && Start.grid[2, 0] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            else if (Start.grid[0, 1] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 1] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            else if (Start.grid[0, 2] == Element.X && Start.grid[1, 2] == Element.X && Start.grid[2, 2] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            /* check for diagonal */
            else if (Start.grid[0, 0] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 2] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            else if (Start.grid[0, 2] == Element.X && Start.grid[1, 1] == Element.X && Start.grid[2, 0] == Element.X)
            {
                Console.WriteLine("Player X wins");
            }
            /* chech for rows */
            else if (Start.grid[0, 0] == Element.O && Start.grid[0, 1] == Element.O && Start.grid[0, 2] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else if (Start.grid[1, 0] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[1, 2] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else if (Start.grid[2, 0] == Element.O && Start.grid[2, 1] == Element.O && Start.grid[2, 2] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            /* check for columns */
            else if (Start.grid[0, 0] == Element.O && Start.grid[1, 0] == Element.O && Start.grid[2, 0] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else if (Start.grid[0, 1] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 1] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else if (Start.grid[0, 2] == Element.O && Start.grid[1, 2] == Element.O && Start.grid[2, 2] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            /* check for diagonal */
            else if (Start.grid[0, 0] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 2] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else if (Start.grid[0, 2] == Element.O && Start.grid[1, 1] == Element.O && Start.grid[2, 0] == Element.O)
            {
                Console.WriteLine("Player O wins");
            }
            else
            {
                Console.WriteLine("It's a draw");
            }

        }
        
    }   
}

