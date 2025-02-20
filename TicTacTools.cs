﻿using System;
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
        public bool ValidateGuess(string guess, List<string> board)
        {
            bool result = true;
            int number;
            bool isNumber = int.TryParse(guess, out number);

            // Check that they are guessing a valid position
            if (!isNumber || number < 0 || number > 8)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 8.");
                result = false;
            }

            // Check if the spot is already taken
            else if (board[number] == "X" || board[number] == "O")
            {
                Console.WriteLine("Sorry, that spot has already been taken.");
                result = false;
            }

            return result;
        }


        // PrintBoard Method
        public void PrintBoard(List<string> board)
        {
            // Print the board based on the array that is passed.
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]} ");
        }


        // ReturnWinner Method

        public bool ReturnWinner(List<string> board)
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
                }       
            }

            // No winner
            return false;
        }
    }
}
