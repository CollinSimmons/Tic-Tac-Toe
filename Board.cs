using System;
namespace Practice
{
    public enum Element
    {
        E,
        X,
        O
    }
    public class Board
	{ 
        public Element[,] grid = new Element[,]
        {
          {Element.E, Element.E , Element.E },
          {Element.E, Element.E , Element.E },
          {Element.E, Element.E , Element.E }
        };

        public void PrintBoard()    
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var cell = grid[i, j];
                    Console.Write(cell);
                    Console.Write(" ");
                    
                }
                Console.Write("\n");

            }
        }
    }
}

