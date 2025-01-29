using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Supporting Class
namespace Mission4
{
    internal class TicTacTools
    {
        // ValidateGuess Method
        public string ValidateGuess(string guess, string[] board)
        {
            int number;
            bool isNumber = int.TryParse(guess, out number);

            // Check that they are guessing a valid position
            if (!isNumber || number < 1 || number > 9)
            {
                return "Invalid input. Please enter a number between 1 and 9.";
            }

            // Check if the spot is already taken
            if (board[number - 1] == "X" || board[number - 1] == "O")
            {
                return "Sorry, that spot has already been taken.";
            }

            return "Valid guess.";
        }


        // PrintBoard Method
        public void PrintBoard(string[] board)
        {
            // Print the board based on the array that is passed.
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]} ");
        }


        // ReturnWinner Method

        public bool ReturnWinner(string[] board)
        {
            // Define the winning combinations
            int[][] winningCombinations = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

            // Check each winning combination
            foreach (var combination in winningCombinations)
            {
                if (board[combination[0]] == board[combination[1]] && board[combination[1]] == board[combination[2]])
                {
                    if (board[combination[0]] == "X")
                    {
                        Console.WriteLine("X wins!");
                        return true;
                    }
                    else if (board[combination[0]] == "O")
                    {
                        Console.WriteLine("O wins!");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }       
            }
        }
    }
}
