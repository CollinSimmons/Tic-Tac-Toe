using System;
namespace Practice
{
    public class Practice
    {
       
        static void Main(string[] args)
        {
            var ifWin = new WinningCondition();
            var PlayerX = new Player(Element.X, Element.O);
            var PLayerO = new Player(Element.O, Element.X);
            var Start = new Board();
            Console.WriteLine("Tic-Tac-Toe:\nTo make a change, enter the name of chosen spot\ntopleft, middlemiddle, bottomright, etc.\nHave fun!");
            Start.PrintBoard();
            for (byte i = 0; i <= 4; i++)
            {
            PlayerX.Play(Start);
            Start.PrintBoard();
            ifWin.xWin(Start);
                if (i == 4)
                {
                    break;
                }
            PLayerO.Play(Start);
            Start.PrintBoard();
            ifWin.oWin(Start);
            }
        }
    }   
}

