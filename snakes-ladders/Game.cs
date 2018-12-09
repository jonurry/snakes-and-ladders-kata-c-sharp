using System;

namespace SnakesLadders
{
  public class Game
  {
    private int position;
    public Game()
    {
      position = 1;
    }
    public int Position
    {
      get => position;
      set => position = value;
    }
  }
}
