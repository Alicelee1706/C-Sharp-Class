/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static char[,] board;
  static int n;
  static char empty = '-';

  static void Main ()
  {
    Console. Write("How many square do you want to play: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("So you want to play {0}x{0} board!", n, n);
    init ();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
	    {
	        if (j == n - 1)
	        {
		        Console.Write (" {0} ", board[i, j] == empty ? ' ' : board[i, j]);
	        } 
	        else
	        {
		        Console.Write (" {0} |", board[i, j] == empty ? ' ' : board[i, j]);
	        }
	    }
	    Console.WriteLine ();
	    for (int j = 0; j < n; j++)
	    {
	        if (j == n - 1)
	        {
		        Console.Write ("---");
	        }
	        else
	        {
		    Console.Write ("---|");
	        }
	    }
	    Console.WriteLine ();
    }
 }

  private static void init ()
  {
    board = new char[n, n];
    for (int i = 0; i < n; i++)
      {
	for (int j = 0; j < n; j++)
	  {
	    board[i, j] = empty;
	  }
      }

  }
}
