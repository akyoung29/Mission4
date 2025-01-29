// Driver class
// Initiate variables 
using System.Runtime.InteropServices;
using Mission4;

TicTacTools tt = new TicTacTools();
//game board array to store player's choices
List<string> gameBoard = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8" }; 

string oneGuess = "";
string twoGuess = "";

bool winner = false;
int turnCount = 0;

bool validCheck = false;

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
        validCheck = false;
        do
        {
            Console.WriteLine("Player one please choose where you would like to play (0-8): ");
            oneGuess = Console.ReadLine();
            //validate guess
            validCheck = tt.ValidateGuess(oneGuess, gameBoard);
            //update board array

        } while (validCheck == false);
        
        gameBoard[int.Parse(oneGuess)] =  "X";
        //increment turncounter 
        turnCount++;

        tt.PrintBoard(gameBoard);
        winner = tt.ReturnWinner(gameBoard);
        if (turnCount >= 9 & winner == false)
        {
            winner = true; //not actually a winner it is a cat game
            Console.WriteLine("GAME OVER! NO PLAYER WON THE GAME");
        }

    if (winner == false)
        {
            //PLAYER 2
            validCheck = false;
            do
            {
                // Ask each player in turn for their choice 
                Console.WriteLine("Player two please choose where you would like to play (0-8): ");
                twoGuess = Console.ReadLine();
                //validate guess
                validCheck = tt.ValidateGuess(twoGuess, gameBoard);

            } while (validCheck == false);
        
            //update board array
            gameBoard[int.Parse(twoGuess)] = "O";
        }
        

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