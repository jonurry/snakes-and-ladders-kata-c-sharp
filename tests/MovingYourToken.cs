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
      Assert.True(_game.Position == 1, "Token does not start on square 1");
    }

    [Fact]
    public void TokenMoves3Spaces()
    {
      _game.Move(3);
      Assert.True(_game.Position == 4, "Token does not move 3 spaces");
    }

    [Fact]
    public void TokenMovesAreIncremental()
    {
      _game.Move(3);
      _game.Move(4);
      Assert.True(_game.Position == 8, "Token moves are not incremental");
    }
  }
}