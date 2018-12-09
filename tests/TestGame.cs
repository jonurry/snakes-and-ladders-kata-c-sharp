using System;
using Xunit;
using SnakesLadders;

namespace SnakesLadders.UnitTests
{
  public class Game_MovingYourTokenShould
  {
    private readonly Game _game;

    public Game_MovingYourTokenShould()
    {
      _game = new Game();
    }

    [Fact]
    public void TokenStartsOnSquare1()
    {
      Assert.True(_game.Position == 1, "1 should not be prime");
    }
  }
}