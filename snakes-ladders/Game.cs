using System;

namespace SnakesLadders
{
  public class Game
  {
    private bool isWon;
    private int position;
    public Game(int startPosition = 1)
    {
      position = startPosition;
      isWon = false;
    }
    public bool IsWon
    {
      get => isWon;
    }
    public void Move(int spaces)
    {
      if (position + spaces <= 100) { position += spaces; }
      isWon = (position == 100);
    }
    public int Position
    {
      get => position;
    }
    public void RollDie()
    {
      Move(1);
    }
  }
}
