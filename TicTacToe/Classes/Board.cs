using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            Console.Write("|" + GameBoard[0, 0] + "|");
            Console.Write("|" + GameBoard[0, 1] + "|");
            Console.Write("|" + GameBoard[0, 2] + "|");
            Console.WriteLine();

            Console.Write("|" + GameBoard[1, 0] + "|");
            Console.Write("|" + GameBoard[1, 1] + "|");
            Console.Write("|" + GameBoard[1, 2] + "|");
            Console.WriteLine();

            Console.Write("|" + GameBoard[2, 0] + "|");
            Console.Write("|" + GameBoard[2, 1] + "|");
            Console.Write("|" + GameBoard[2, 2] + "|");

        }
	}
}
