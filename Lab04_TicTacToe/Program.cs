using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        /// <summary>
        /// Executes the game logic.
        /// </summary>
        static void PlayGame()
        {
           
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to TicTacToe.NET!\n");
                Console.Write("Player 1, please enter your name: ");
                Player player1 = new Player()
                {
                    Name = Console.ReadLine(),
                    IsTurn = true,
                    Marker = "X"
                };

                Console.Write("Player 2, please enter your name: ");
                Player player2 = new Player()
                {
                    Name = Console.ReadLine(),
                    IsTurn = false,
                    Marker = "O"
                };

                Game game = new Game(player1, player2);
                Player winner = game.Play();

                if (winner is null) Console.WriteLine("It's a draw!");
                else Console.WriteLine($"{winner.Name} wins!");

                Console.WriteLine("\nWould you like to play again?");
                Console.WriteLine("Enter y to play again, enter anything else to exit.");
                Console.Write("> ");
            } while (Console.ReadLine().ToLower() == "y");

        }
    }
}
