using System;
namespace TicTacToe_gr6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating two boards - starting board and board with current fields
            char[,] startBoard =
            {
                {'1', '2','3'},
                {'4', '5','6'},
                {'7', '8','9'}
            };
            char[,] gameBoard = startBoard.Clone() as char[,];
            //Flags
            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true; // true - player 1 move, false - player 2 move
                              
                                //////////////////////////////
            // loop over rounds
            for(int round = 0; round < gameBoard.Length;round++)
            {
                Console.Clear();
                //TODO:draw the board
                if (nextIsPlayer1)
                {
                    //TODO: player 1 move
                    nextIsPlayer1 = false;
                }
                else
                {
                    //TODO player 2 move
                    nextIsPlayer1 = true;
                }
                if (player1Won || player2Won)
                    break;
            }
                                ////////////////////////////////
                //END THE GAME
                Console.Clear();
            //TODO DRAW THE BOARD
            Console.WriteLine("Game ended!");
            //TODO WRITELINE WHO WON
            Console.WriteLine();
        }
    }
}