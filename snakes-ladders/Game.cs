using System;

namespace SnakesLadders
{
  public interface IRandomDieRoller
  {
    int RollDie();
  }
  public class Game
  {
    private readonly IRandomDieRoller _dieRoller;
    private class DefaultDieRoller : IRandomDieRoller
    {
      public int RollDie()
      {
        return (new Random()).Next(1, 7);
      }
    }
    private bool isWon;
    private int position;
    public Game(IRandomDieRoller dieRoller, int startPosition = 1)
    {
      _dieRoller = dieRoller;
      position = startPosition;
      isWon = false;
    }
    public Game(int startPosition = 1) : this(new DefaultDieRoller())
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
      Move(_dieRoller.RollDie());
    }
  }
}
