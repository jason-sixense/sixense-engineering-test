/* THIS IS UNFINISHED, EXPERIMENTING WITH A ASCII DISPLAY OF RESULTS */

using System;
using System.Threading;

public class GameBoard
{
  private const int LENGTH = 25;
  private const int WIDTH = 25;
  private char[,] array = new char[LENGTH, WIDTH];
  private Person c;
  private int iP = 0;
  private int jP = 0;

  public GameBoard() {
   
   Update();
  }

  private void Update() {

    Console.CursorVisible = false;
    Console.Clear();
    for (int i = 0; i < 25; ++i) 
    {
      iP = jP = i;
      DrawBoard();
      Thread.Sleep(500);
      Console.Clear();
    }
  }

  private void DrawBoard() {

    for (int i = 0; i < WIDTH; ++i) {
      for (int j = 0; j < LENGTH; ++j) {
        char ch = i == iP && j == jP ? 'P' : '*';
        Console.Write(ch);
        Console.Write(' ');
      }
      Console.Write('\n');
    }
  }
}