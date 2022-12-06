using System;


class Program
{
  // place holders for the XO
  static string[] board = new string [9] {" - ", " - ", " - ", " - ", " - ", " - ", " - ", " - ", " - "};

  // main game program 
  static void Main(string[] args)
  {
    for (int k = 0; k < 9; k++)
    {
      Console.Write("Choose your move: ");
      string? move = Console.ReadLine();

      if (move == null) 
      {
        Console.WriteLine("readline returned null");
        continue;
      }
    
      int number;
      string player;

      bool success = int.TryParse(move, out number);
      if (success)
      {
        // one variable for original string and another for the convert to int 
        if (k%2 == 0)
        {
          // if even player 1
          board[number - 1] = " O ";
        }
        else if (k%2 == 1)
        {
          // if odd player 2
          board[number - 1] = " X ";
        }
      }
      
      else
      {
        Console.WriteLine("Invaild Input");
      }

      makeBoard();
    }
  }

  // making of the board 
  static void makeBoard()
  {
    for (int i = 0; i < 9; i++)
    {
      if ((i == 3) || (i == 6)) 
      {
        Console.WriteLine("");
      }
      Console.Write(board[i]);
    }
    Console.WriteLine("");
  }

  // public static bool gameOver ()

}