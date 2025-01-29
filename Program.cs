// Driver class
// Initiate variables 
using System.Runtime.InteropServices;
using Mission4;

TicTacTools tt = new TicTacTools();
//game board array to store player's choices
List<string> gameBoard = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; 

string oneGuess = "";
string twoGuess = "";

bool winner = false;
int turnCount = 0;

// Welcome the user to the game
Console.WriteLine("Welcome to group 3-1's TicTacToe Game! Good luck!");
Console.WriteLine();
//Get player information

Console.WriteLine("Player 1 will be Xs");

Console.WriteLine($"Player 2 will be Os");
Console.WriteLine();

//display the first game board 
tt.PrintBoard(gameBoard);

//Game loop begins until winner 
do
{
        //PLAYER 1
        // Ask each player in turn for their choice 
        Console.WriteLine("Player one please choose where you would like to play (1-9): ");
        oneGuess = Console.ReadLine();
        //validate guess
        tt.ValidateGuess(oneGuess);
        //update board array
        gameBoard.Insert(int.Parse(oneGuess), "X");

        tt.PrintBoard(gameBoard);

        //PLAYER 2
        // Ask each player in turn for their choice 
        Console.WriteLine("Player two please choose where you would like to play (1-9): ");
        twoGuess = Console.ReadLine();
        //validate guess
        tt.ValidateGuess(twoGuess);
        //update board array
        gameBoard.Insert(int.Parse(twoGuess), "O");

        //increment turncounter 
        turnCount++;

        tt.PrintBoard(gameBoard);
        winner = tt.ReturnWinner(gameBoard);

        if (turnCount >= 9 & winner == false)
        {
        winner = true; //not actually a winner it is a cat game
        Console.WriteLine("GAME OVER! NO PLAYER WON THE GAME");
        }

    } while (winner == false);

Console.WriteLine("Thanks for playing! To play again, exit and restart the program");