using System;

namespace SnakesLadders
{
  public class Game
  {
    private bool isWon;
    private int position;
    public Game()
    {
      position = 1;
      isWon = false;
    }
    public bool IsWon
    {
      get => isWon;
    }
    public void Move(int spaces)
    {
      position += spaces;
      if (position == 100) { isWon = true; }
    }
    public int Position
    {
      get => position;
      set => position = value;
    }
  }
}
